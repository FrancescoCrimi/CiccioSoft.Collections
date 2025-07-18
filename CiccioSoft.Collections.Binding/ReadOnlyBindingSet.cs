// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace CiccioSoft.Collections.Binding
{
    /// <summary>
    /// Read-only wrapper around an BindingSet.
    /// </summary>
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class ReadOnlyBindingSet<T> : Core.ReadOnlySet<T>, ICollection<T>, ISet<T>, IReadOnlyCollection<T>, IReadOnlySet<T>, IBindingList, IRaiseItemChangedEvents
    {
        private readonly IBindingList _inner;
        private readonly object _evtLock = new();
        [NonSerialized]
        private ListChangedEventHandler? _listChanged;
        
        #region Constructors

        /// <summary>
        /// Initializes a new instance of ReadOnlyBindingSet that
        /// wraps the given BindingSet.
        /// </summary>
        public ReadOnlyBindingSet(BindingHashSet<T> set) : base(set)
        {
            _inner = set;
        }

        #endregion

        #region ListChanged event

        /// <summary>
        /// Event that reports changes to the list or to items in the list.
        /// </summary>
        public event ListChangedEventHandler? ListChanged
        {
            add
            {
                lock (_evtLock)
                {
                    var wasEmpty = _listChanged == null;
                    _listChanged += value;
                    if (wasEmpty)
                        _inner.ListChanged += HandleInnerListChanged;
                }
            }
            remove
            {
                lock (_evtLock)
                {
                    _listChanged -= value;
                    if (_listChanged == null)
                        _inner.ListChanged -= HandleInnerListChanged;
                }
            }
        }

        /// <summary>
        /// Raises the ListChanged event.
        /// </summary>
        protected virtual void OnListChanged(ListChangedEventArgs e)
        {
            var handler = _listChanged;
            handler?.Invoke(this, e);
        }

        private void HandleInnerListChanged(object? sender, ListChangedEventArgs e)
            => OnListChanged(e);

        #endregion

        #region IBindingList interface

        object? IBindingList.AddNew() => throw new NotSupportedException();

        bool IBindingList.AllowNew => false;

        bool IBindingList.AllowEdit => false;

        bool IBindingList.AllowRemove => false;

        bool IBindingList.SupportsChangeNotification => _inner.SupportsChangeNotification;

        bool IBindingList.SupportsSearching => _inner.SupportsSearching;

        bool IBindingList.SupportsSorting => _inner.SupportsSorting;

        bool IBindingList.IsSorted => _inner.IsSorted;

        PropertyDescriptor? IBindingList.SortProperty => _inner.SortProperty;

        ListSortDirection IBindingList.SortDirection => _inner.SortDirection;

        void IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction)
            => throw new NotSupportedException();

        void IBindingList.RemoveSort() => throw new NotSupportedException();

        int IBindingList.Find(PropertyDescriptor prop, object key) => _inner.Find(prop, key);

        void IBindingList.AddIndex(PropertyDescriptor prop) => _inner.AddIndex(prop);

        void IBindingList.RemoveIndex(PropertyDescriptor prop) => _inner.RemoveIndex(prop);

        #endregion

        #region IList Non Generic interface

        object? IList.this[int index]
        {
            get => Set.ToList()[index];
            set => ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        bool IList.IsFixedSize => true;

        bool IList.IsReadOnly => true;

        int IList.Add(object? value)
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            return -1;
        }

        void IList.Clear()
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
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
                return Set.ToList().IndexOf((T)value!);
            }
            return -1;
        }

        void IList.Insert(int index, object? value)
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        void IList.Remove(object? value)
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        void IList.RemoveAt(int index)
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        #endregion

        #region IRaiseItemChangedEvents interface

        /// <summary>
        /// Returns false to indicate that ReadOnlyBindingSet&lt;T&gt; does NOT raise ListChanged events
        /// of type ItemChanged as a result of property changes on individual list items
        /// unless those items support INotifyPropertyChanged.
        /// </summary>
        public bool RaisesItemChangedEvents => ((IRaiseItemChangedEvents)Set).RaisesItemChangedEvents;

        #endregion

        #region Private Methods

        private static bool IsCompatibleObject(object? value)
        {
            // Non-null values are fine.  Only accept nulls if T is a class or Nullable<U>.
            // Note that default(T) is not equal to null for value types except when T is Nullable<U>.
            return value is T || value == null && default(T) == null;
        }

        #endregion
    }
}
