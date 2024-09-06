// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace CiccioSoft.Collections
{
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    [Serializable]
    public class BindingSet<T> : SetBase<T>, ICollection<T>, ISet<T>, IReadOnlyCollection<T>, IReadOnlySet<T>, IBindingList, IRaiseItemChangedEvents
    {
        private bool raiseItemChangedEvents; // Do not rename (binary serialization)

        [NonSerialized]
        private PropertyDescriptorCollection? _itemTypeProperties;

        [NonSerialized]
        private PropertyChangedEventHandler? _propertyChangedEventHandler;

        [NonSerialized]
        private ListChangedEventHandler? _onListChanged;

        [NonSerialized]
        private int _lastChangeIndex = -1;


        #region Constructors

        public BindingSet()
        {
            Initialize();
        }

        public BindingSet(IEqualityComparer<T>? comparer) : base(comparer)
        {
            Initialize();
        }

        public BindingSet(int capacity) : base(capacity)
        {
            Initialize();
        }

        public BindingSet(IEnumerable<T> collection) : base(collection)
        {
            Initialize();
        }

        public BindingSet(IEnumerable<T> collection, IEqualityComparer<T>? comparer) : base(collection, comparer)
        {
            Initialize();
        }

        public BindingSet(int capacity, IEqualityComparer<T>? comparer) : base(capacity, comparer)
        {
            Initialize();
        }

        private void Initialize()
        {
            // Check for INotifyPropertyChanged
            if (typeof(INotifyPropertyChanged).IsAssignableFrom(typeof(T)))
            {
                // Supports INotifyPropertyChanged
                raiseItemChangedEvents = true;

                // Loop thru the items already in the collection and hook their change notification.
                foreach (T item in _set)
                {
                    HookPropertyChanged(item);
                }
            }
        }

        #endregion


        #region Overrides Method

        protected override bool AddItem(T item)
        {
            if (_set.Contains(item))
            {
                return false;
            }

            _set.Add(item);

            int index = _set.ToList().IndexOf(item);
            if (raiseItemChangedEvents)
            {
                HookPropertyChanged(item);
            }
            FireListChanged(ListChangedType.ItemAdded, index);

            return true;
        }

        protected override void ClearItems()
        {
            if (_set.Count == 0)
            {
                return;
            }

            if (raiseItemChangedEvents)
            {
                foreach (T item in _set)
                {
                    UnhookPropertyChanged(item);
                }
            }

            _set.Clear();

            FireListChanged(ListChangedType.Reset, -1);
        }

        protected override void ExceptWithItems(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(_set, _set.Comparer);
            copy.ExceptWith(other);
            if (copy.Count == _set.Count)
            {
                return;
            }
            var removed = _set.Where(i => !copy.Contains(i)).ToList();

            if (raiseItemChangedEvents)
            {
                foreach (T item in removed)
                {
                    UnhookPropertyChanged(item);
                }
            }

            _set = copy;

            FireListChanged(ListChangedType.Reset, -1);
        }

        protected override void IntersectWithItems(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(_set, _set.Comparer);
            copy.IntersectWith(other);
            if (copy.Count == _set.Count)
            {
                return;
            }
            var removed = _set.Where(i => !copy.Contains(i)).ToList();

            if (raiseItemChangedEvents)
            {
                foreach (T item in removed)
                {
                    UnhookPropertyChanged(item);
                }
            }

            _set = copy;

            FireListChanged(ListChangedType.Reset, -1);
        }

        protected override bool RemoveItem(T item)
        {
            if (!_set.Contains(item))
            {
                return false;
            }

            if (raiseItemChangedEvents)
            {
                UnhookPropertyChanged(item);
            }
            int index = _set.ToList().IndexOf(item);

            _set.Remove(item);

            FireListChanged(ListChangedType.ItemDeleted, index);

            return true;
        }

        protected override void SymmetricExceptWithItems(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(_set, _set.Comparer);
            copy.SymmetricExceptWith(other);
            var removed = _set.Where(i => !copy.Contains(i)).ToList();
            var added = copy.Where(i => !_set.Contains(i)).ToList();

            if (removed.Count == 0
                && added.Count == 0)
            {
                return;
            }

            if (raiseItemChangedEvents)
            {
                foreach (T item in added)
                {
                    HookPropertyChanged(item);
                }
                foreach (T item in removed)
                {
                    UnhookPropertyChanged(item);
                }
            }

            _set = copy;

            FireListChanged(ListChangedType.Reset, -1);
        }

        protected override void UnionWithItems(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(_set, _set.Comparer);
            copy.UnionWith(other);
            if (copy.Count == _set.Count)
            {
                return;
            }
            var added = copy.Where(i => !_set.Contains(i)).ToList();

            if (raiseItemChangedEvents)
            {
                foreach (T item in added)
                {
                    HookPropertyChanged(item);
                }
            }

            _set = copy;

            FireListChanged(ListChangedType.Reset, -1);
        }

        #endregion


        #region ListChanged event

        /// <summary>
        /// Event that reports changes to the list or to items in the list.
        /// </summary>
        public event ListChangedEventHandler ListChanged
        {
            add => _onListChanged += value;
            remove => _onListChanged -= value;
        }

        // Private helper method
        private void FireListChanged(ListChangedType type, int index)
        {
            OnListChanged(new ListChangedEventArgs(type, index));
        }

        /// <summary>
        /// Raises the ListChanged event.
        /// </summary>
        private void OnListChanged(ListChangedEventArgs e) => _onListChanged?.Invoke(this, e);

        #endregion


        #region Property Change Support

        private void HookPropertyChanged(T item)
        {
            // Note: inpc may be null if item is null, so always check.
            if (item is INotifyPropertyChanged inpc)
            {
                _propertyChangedEventHandler ??= new PropertyChangedEventHandler(Child_PropertyChanged);
                inpc.PropertyChanged += _propertyChangedEventHandler;
            }
        }

        private void UnhookPropertyChanged(T item)
        {
            // Note: inpc may be null if item is null, so always check.
            if (item is INotifyPropertyChanged inpc && _propertyChangedEventHandler != null)
            {
                inpc.PropertyChanged -= _propertyChangedEventHandler;
            }
        }

        private void Child_PropertyChanged(object? sender, PropertyChangedEventArgs? e)
        {
            if (sender == null || e == null || string.IsNullOrEmpty(e.PropertyName))
            {
                // Fire reset event (per INotifyPropertyChanged spec)
                FireListChanged(ListChangedType.Reset, -1);
            }
            else
            {
                // The change event is broken should someone pass an item to us that is not
                // of type T. Still, if they do so, detect it and ignore. It is an incorrect
                // and rare enough occurrence that we do not want to slow the mainline path
                // with "is" checks.
                T item;

                try
                {
                    item = (T)sender;
                }
                catch (InvalidCastException)
                {
                    // Fire reset event 
                    FireListChanged(ListChangedType.Reset, -1);
                    return;
                }

                // Find the position of the item. This should never be -1. If it is,
                // somehow the item has been removed from our list without our knowledge.
                int pos = _lastChangeIndex;

                if (pos < 0 || pos >= Count || !_set.ToList()[pos]!.Equals(item))
                {
                    pos = _set.ToList().IndexOf(item);
                    _lastChangeIndex = pos;
                }

                if (pos == -1)
                {
                    // The item was removed from the list but we still get change notifications or
                    // the sender is invalid and was never added to the list.
                    UnhookPropertyChanged(item);
                    // Fire reset event 
                    FireListChanged(ListChangedType.Reset, -1);
                }
                else
                {
                    // Get the property descriptor
                    if (null == _itemTypeProperties)
                    {
                        // Get Shape
                        _itemTypeProperties = TypeDescriptor.GetProperties(typeof(T));
                        Debug.Assert(_itemTypeProperties != null);
                    }

                    PropertyDescriptor? pd = _itemTypeProperties.Find(e.PropertyName, true);

                    // Create event args. If there was no matching property descriptor,
                    // we raise the list changed anyway.
                    ListChangedEventArgs args = new ListChangedEventArgs(ListChangedType.ItemChanged, pos, pd);

                    // Fire the ItemChanged event
                    OnListChanged(args);
                }
            }
        }

        #endregion


        #region IBindingList interface

        public T AddNew() => throw new NotSupportedException();

        object? IBindingList.AddNew() => throw new NotSupportedException();

        public bool AllowNew => false;

        bool IBindingList.AllowNew => false;

        public bool AllowEdit => true;

        bool IBindingList.AllowEdit => AllowEdit;

        public bool AllowRemove => true;

        bool IBindingList.AllowRemove => AllowRemove;

        bool IBindingList.SupportsChangeNotification => true;

        bool IBindingList.SupportsSearching => false;

        bool IBindingList.SupportsSorting => false;

        bool IBindingList.IsSorted => false;

        PropertyDescriptor? IBindingList.SortProperty => null;

        ListSortDirection IBindingList.SortDirection => ListSortDirection.Ascending;

        void IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction) => throw new NotSupportedException();

        void IBindingList.RemoveSort() => throw new NotSupportedException();

        int IBindingList.Find(PropertyDescriptor prop, object key) => throw new NotSupportedException();

        void IBindingList.AddIndex(PropertyDescriptor prop)
        {
            // Not supported
        }

        void IBindingList.RemoveIndex(PropertyDescriptor prop)
        {
            // Not supported
        }

        #endregion


        #region IRaiseItemChangedEvents interface

        /// <summary>
        /// Returns false to indicate that BindingList&lt;T&gt; does NOT raise ListChanged events
        /// of type ItemChanged as a result of property changes on individual list items
        /// unless those items support INotifyPropertyChanged.
        /// </summary>
        bool IRaiseItemChangedEvents.RaisesItemChangedEvents => raiseItemChangedEvents;

        #endregion


        #region IList ICollection

        bool ICollection.IsSynchronized => false;

        object ICollection.SyncRoot => this;

        void ICollection.CopyTo(Array array, int index)
        {
            if (array == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
            }

            if (array.Rank != 1)
            {
                ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
            }

            if (array.GetLowerBound(0) != 0)
            {
                ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
            }

            if (index < 0)
            {
                ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
            }

            if (array.Length - index < Count)
            {
                ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
            }

            if (array is T[] tArray)
            {
                _set.CopyTo(tArray, index);
            }
            else
            {
                //
                // Catch the obvious case assignment will fail.
                // We can't find all possible problems by doing the check though.
                // For example, if the element type of the Array is derived from T,
                // we can't figure out if we can successfully copy the element beforehand.
                //
                Type targetType = array.GetType().GetElementType()!;
                Type sourceType = typeof(T);
                if (!(targetType.IsAssignableFrom(sourceType) || sourceType.IsAssignableFrom(targetType)))
                {
                    ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
                }

                //
                // We can't cast array of value type to object[], so we don't support
                // widening of primitive types here.
                //
                object?[]? objects = array as object[];
                if (objects == null)
                {
                    ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
                }

                //int count = items.Count;
                try
                {
                    //for (int i = 0; i < count; i++)
                    //{
                    //    objects[index++] = items[i];
                    //}
                    foreach (var item in (IEnumerable)_set)
                    {
                        objects[index++] = item;
                    }
                }
                catch (ArrayTypeMismatchException)
                {
                    ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
                }
            }
        }

        object? IList.this[int index]
        {
            get => _set.ToList()[index];
            set => throw new NotSupportedException("Mutating a value collection derived from a hashset is not allowed.");
        }

        bool IList.IsReadOnly => false;

        bool IList.IsFixedSize => false;

        int IList.Add(object? value)
        {
            ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);

            T? item = default;

            try
            {
                item = (T)value!;
            }
            catch (InvalidCastException)
            {
                ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
            }

            Add(item);

            return _set.ToList().IndexOf(item);
        }

        bool IList.Contains(object? value)
        {
            if (IsCompatibleObject(value))
            {
                return Contains((T)value!);
            }
            return false;
        }

        int IList.IndexOf(object? value)
        {
            if (IsCompatibleObject(value))
            {
                return _set.ToList().IndexOf((T)value!);
            }
            return -1;
        }

        void IList.Insert(int index, object? value)
        {
            throw new NotSupportedException("Mutating a value collection derived from a hashset is not allowed.");
        }

        void IList.Remove(object? value)
        {
            if (IsCompatibleObject(value))
            {
                Remove((T)value!);
            }
        }

        void IList.RemoveAt(int index)
        {
            throw new NotSupportedException("Mutating a value collection derived from a hashset is not allowed.");
        }

        private static bool IsCompatibleObject(object? value)
        {
            // Non-null values are fine.  Only accept nulls if T is a class or Nullable<U>.
            // Note that default(T) is not equal to null for value types except when T is Nullable<U>.
            return (value is T) || (value == null && default(T) == null);
        }

        #endregion
    }
}
