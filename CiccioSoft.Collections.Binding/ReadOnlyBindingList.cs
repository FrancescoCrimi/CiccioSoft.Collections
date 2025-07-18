// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace CiccioSoft.Collections.Binding
{
    /// <summary>
    /// Read-only wrapper around an BindingList.
    /// </summary>
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class ReadOnlyBindingList<T> : ReadOnlyCollection<T>, IBindingList, IRaiseItemChangedEvents
    {
        private readonly IBindingList _inner;
        private readonly object _evtLock = new();
        [NonSerialized]
        private ListChangedEventHandler? _listChanged;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of ReadOnlyBindingList that
        /// wraps the given BindingList.
        /// </summary>
        public ReadOnlyBindingList(BindingList<T> bindingList) : base(bindingList)
        {
            _inner = bindingList;
        }

        public ReadOnlyBindingList(System.ComponentModel.BindingList<T> bindingList) : base(bindingList)
        {
            _inner = bindingList;
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

        #region IRaiseItemChangedEvents interface

        /// <summary>
        /// Returns false to indicate that ReadOnlyBindingList&lt;T&gt; does NOT raise ListChanged events
        /// of type ItemChanged as a result of property changes on individual list items
        /// unless those items support INotifyPropertyChanged.
        /// </summary>
        public bool RaisesItemChangedEvents => ((IRaiseItemChangedEvents)Items).RaisesItemChangedEvents;

        #endregion
    }
}
