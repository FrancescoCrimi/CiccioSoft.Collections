// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using CiccioSoft.Collections.Core;
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
    public class ReadOnlyBindingSet<T> : ReadOnlySetMoreIList<T>, ICollection<T>, ISet<T>, IReadOnlyCollection<T>, IReadOnlySet<T>, IBindingList, IRaiseItemChangedEvents
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of ReadOnlyBindingSet that
        /// wraps the given BindingSet.
        /// </summary>
        public ReadOnlyBindingSet(BindingSet<T> set) : base(set)
        {
            set.ListChanged += new ListChangedEventHandler(HandleListChanged);
        }

        #endregion

        #region ListChanged

        /// <summary>
        /// Event that reports changes to the list or to items in the list.
        /// </summary>
        [field: NonSerialized]
        public event ListChangedEventHandler? ListChanged;

        /// <summary>
        /// Raises the ListChanged event.
        /// </summary>
        protected virtual void OnListChanged(ListChangedEventArgs e)
        {
            ListChanged?.Invoke(this, e);
        }

        private void HandleListChanged(object? sender, ListChangedEventArgs e)
        {
            OnListChanged(e);
        }

        #endregion

        #region IBindingList interface

        object? IBindingList.AddNew() => throw new NotSupportedException();

        bool IBindingList.AllowNew => false;

        bool IBindingList.AllowEdit => false;

        bool IBindingList.AllowRemove => false;

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
        /// Returns false to indicate that ReadOnlyBindingSet&lt;T&gt; does NOT raise ListChanged events
        /// of type ItemChanged as a result of property changes on individual list items
        /// unless those items support INotifyPropertyChanged.
        /// </summary>
        public bool RaisesItemChangedEvents => ((IRaiseItemChangedEvents)_set).RaisesItemChangedEvents;

        #endregion
    }
}
