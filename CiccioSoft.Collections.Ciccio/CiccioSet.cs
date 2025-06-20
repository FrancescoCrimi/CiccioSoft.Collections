// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using CiccioSoft.Collections.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;

namespace CiccioSoft.Collections.Ciccio
{
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class CiccioSet<T> : SetMoreIList<T>, ICollection<T>, ISet<T>, IReadOnlyCollection<T>, IReadOnlySet<T>, INotifyCollectionChanged, INotifyPropertyChanged, IBindingList, IRaiseItemChangedEvents
    {
        //private SimpleMonitor? _monitor; // Lazily allocated only when a subclass calls BlockReentrancy() or during serialization. Do not rename (binary serialization)

        [NonSerialized]
        private int _blockReentrancyCount;

        private bool raiseItemChangedEvents; // Do not rename (binary serialization)

        [NonSerialized]
        private PropertyDescriptorCollection? _itemTypeProperties;

        [NonSerialized]
        private int _lastChangeIndex = -1;

        #region Constructors

        public CiccioSet()
        {
            Initialize();
        }

        public CiccioSet(IEqualityComparer<T>? comparer) : base(comparer)
        {
            Initialize();
        }

#if  NET472_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NET6_0_OR_GREATER

        public CiccioSet(int capacity) : base(capacity)
        {
            Initialize();
        }

#endif

        public CiccioSet(IEnumerable<T> collection) : base(collection)
        {
            Initialize();
        }

        public CiccioSet(IEnumerable<T> collection, IEqualityComparer<T>? comparer) : base(collection, comparer)
        {
            Initialize();
        }

#if  NET472_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NET6_0_OR_GREATER

        public CiccioSet(int capacity, IEqualityComparer<T>? comparer) : base(capacity, comparer)
        {
            Initialize();
        }

#endif

        private void Initialize()
        {
            // Check for INotifyPropertyChanged
            if (typeof(INotifyPropertyChanged).IsAssignableFrom(typeof(T)))
            {
                // Supports INotifyPropertyChanged
                raiseItemChangedEvents = true;

                // Loop thru the items already in the collection and hook their change notification.
                foreach (T item in items)
                {
                    HookPropertyChanged(item);
                }
            }
        }

#endregion

        #region Overrides Method

        protected override bool AddItem(T item)
        {
            if (items.Contains(item))
            {
                return false;
            }

            CheckReentrancy();

            items.Add(item);

            int index = items.ToList().IndexOf(item);
            if (raiseItemChangedEvents)
            {
                HookPropertyChanged(item);
            }
            FireListChanged(ListChangedType.ItemAdded, index);

            OnCollectionChanged(NotifyCollectionChangedAction.Add, item);
            OnCountPropertyChanged();

            return true;
        }

        protected override void ClearItems()
        {
            if (items.Count == 0)
            {
                return;
            }

            if (raiseItemChangedEvents)
            {
                foreach (T item in items)
                {
                    UnhookPropertyChanged(item);
                }
            }

            CheckReentrancy();
            var removed = this.ToList();

            items.Clear();

            FireListChanged(ListChangedType.Reset, -1);

            OnCollectionChanged(EventArgsCache.NoItems, removed);
            OnCountPropertyChanged();
        }

        protected override void ExceptWithItems(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.ExceptWith(other);
            if (copy.Count == items.Count)
            {
                return;
            }
            var removed = items.Where(i => !copy.Contains(i)).ToList();

            if (raiseItemChangedEvents)
            {
                foreach (T item in removed)
                {
                    UnhookPropertyChanged(item);
                }
            }

            CheckReentrancy();

            items = copy;

            FireListChanged(ListChangedType.Reset, -1);

            OnCollectionChanged(EventArgsCache.NoItems, removed);
            OnCountPropertyChanged();
        }

        protected override void IntersectWithItems(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.IntersectWith(other);
            if (copy.Count == items.Count)
            {
                return;
            }
            var removed = items.Where(i => !copy.Contains(i)).ToList();

            if (raiseItemChangedEvents)
            {
                foreach (T item in removed)
                {
                    UnhookPropertyChanged(item);
                }
            }

            CheckReentrancy();

            items = copy;

            FireListChanged(ListChangedType.Reset, -1);

            OnCollectionChanged(EventArgsCache.NoItems, removed);
            OnCountPropertyChanged();
        }

        protected override bool RemoveItem(T item)
        {
            if (!items.Contains(item))
            {
                return false;
            }

            if (raiseItemChangedEvents)
            {
                UnhookPropertyChanged(item);
            }
            int index = items.ToList().IndexOf(item);

            CheckReentrancy();

            items.Remove(item);

            FireListChanged(ListChangedType.ItemDeleted, index);

            OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);
            OnCountPropertyChanged();

            return true;
        }

        protected override void SymmetricExceptWithItems(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.SymmetricExceptWith(other);
            var removed = items.Where(i => !copy.Contains(i)).ToList();
            var added = copy.Where(i => !items.Contains(i)).ToList();

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

            CheckReentrancy();

            items = copy;

            FireListChanged(ListChangedType.Reset, -1);

            OnCollectionChanged(added, removed);
            OnCountPropertyChanged();
        }

        protected override void UnionWithItems(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.UnionWith(other);
            if (copy.Count == items.Count)
            {
                return;
            }
            var added = copy.Where(i => !items.Contains(i)).ToList();

            if (raiseItemChangedEvents)
            {
                foreach (T item in added)
                {
                    HookPropertyChanged(item);
                }
            }

            CheckReentrancy();

            items = copy;

            FireListChanged(ListChangedType.Reset, -1);

            OnCollectionChanged(added, EventArgsCache.NoItems);
            OnCountPropertyChanged();
        }

        #endregion

        #region PropertyChanged

        /// <summary>
        /// PropertyChanged event (per <see cref="INotifyPropertyChanged" />).
        /// </summary>
        [field: NonSerialized]
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Raises a PropertyChanged event (per <see cref="INotifyPropertyChanged" />).
        /// </summary>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Helper to raise a PropertyChanged event for the Count property
        /// </summary>
        private void OnCountPropertyChanged() => OnPropertyChanged(EventArgsCache.CountPropertyChanged);

        #endregion

        #region CollectionChanged

        /// <summary>
        /// Occurs when the collection changes, either by adding or removing an item.
        /// </summary>
        [field: NonSerialized]
        public virtual event NotifyCollectionChangedEventHandler? CollectionChanged;

        /// <summary> Check and assert for reentrant attempts to change this collection. </summary>
        /// <exception cref="InvalidOperationException"> raised when changing the collection
        /// while another collection change is still being notified to other listeners </exception>
        private void CheckReentrancy()
        {
            if (_blockReentrancyCount > 0)
            {
                // we can allow changes if there's only one listener - the problem
                // only arises if reentrant changes make the original event args
                // invalid for later listeners.  This keeps existing code working
                // (e.g. Selector.SelectedItems).
                if (CollectionChanged?.GetInvocationList().Length > 1)
                    throw new InvalidOperationException("Cannot change ObservableCollection during a CollectionChanged event.");
            }
        }

        /// <summary>
        /// Raise CollectionChanged event to any listeners.
        /// </summary>
        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (CollectionChanged != null)
            {
                // Not calling BlockReentrancy() here to avoid the SimpleMonitor allocation.
                _blockReentrancyCount++;
                try
                {
                    CollectionChanged.Invoke(this, e);
                }
                finally
                {
                    _blockReentrancyCount--;
                }
            }
        }

        private void OnCollectionChanged(NotifyCollectionChangedAction action, object? item)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item));
        }

        private void OnCollectionChanged(IList newItems, IList oldItems)
            => OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newItems, oldItems));

        #endregion

        #region ListChanged

        /// <summary>
        /// Event that reports changes to the list or to items in the list.
        /// </summary>
        [field: NonSerialized]
        public event ListChangedEventHandler? ListChanged;

        // Private helper method
        private void FireListChanged(ListChangedType type, int index)
        {
            OnListChanged(new ListChangedEventArgs(type, index));
        }

        /// <summary>
        /// Raises the ListChanged event.
        /// </summary>
        protected virtual void OnListChanged(ListChangedEventArgs e)
        {
            ListChanged?.Invoke(this, e);
        }

        #endregion

        #region Property Change Support

        private void HookPropertyChanged(T item)
        {
            // Note: inpc may be null if item is null, so always check.
            if (item is INotifyPropertyChanged inpc)
            {
                inpc.PropertyChanged += Child_PropertyChanged;
            }
        }

        private void UnhookPropertyChanged(T item)
        {
            // Note: inpc may be null if item is null, so always check.
            if (item is INotifyPropertyChanged inpc)
            {
                inpc.PropertyChanged -= Child_PropertyChanged;
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

                if (pos < 0 || pos >= Count || !items.ToList()[pos]!.Equals(item))
                {
                    pos = items.ToList().IndexOf(item);
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
        public bool RaisesItemChangedEvents => raiseItemChangedEvents;

        #endregion
    }
}
