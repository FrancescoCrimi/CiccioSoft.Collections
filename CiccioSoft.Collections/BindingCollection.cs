// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Francesco Crimi francrim@gmail.com

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace CiccioSoft.Collections.Generic
{
    [Serializable]
    [DebuggerTypeProxy(typeof(CollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class BindingCollection<T> : Collection<T>, IBindingList, IRaiseItemChangedEvents, IReadOnlyList<T>
    {
        private bool raiseItemChangedEvents;
        [NonSerialized]
        private PropertyDescriptorCollection itemTypeProperties;
        [NonSerialized]
        private int lastChangeIndex = -1;


        #region Constructors

        public BindingCollection() : base() { Initialize(); }
        public BindingCollection(IList<T> list) : base(list) { Initialize(); }
        public BindingCollection(IEnumerable<T> collection) : base(new List<T>(collection)) { Initialize(); }
        public BindingCollection(int capacity) : base(new List<T>(capacity)) { Initialize(); }

        private void Initialize()
        {
            if (typeof(INotifyPropertyChanged).IsAssignableFrom(typeof(T)))
            {
                raiseItemChangedEvents = true;
                foreach (T item in Items)
                {
                    HookPropertyChanged(item);
                }
            }
        }

        #endregion


        public bool IsReadOnly => Items.IsReadOnly;


        #region Collection<T> overrides

        protected override void ClearItems()
        {
            if (raiseItemChangedEvents)
            {
                foreach (T item in this.Items)
                {
                    UnhookPropertyChanged(item);
                }
            }
            base.ClearItems();
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void InsertItem(int index, T item)
        {
            base.InsertItem(index, item);
            if (raiseItemChangedEvents)
                HookPropertyChanged(item);
            OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
        }

        protected override void RemoveItem(int index)
        {
            if (raiseItemChangedEvents)
                UnhookPropertyChanged(this[index]);
            base.RemoveItem(index);
            OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
        }

        protected override void SetItem(int index, T item)
        {
            if (raiseItemChangedEvents)
                UnhookPropertyChanged(this[index]);
            base.SetItem(index, item);
            if (raiseItemChangedEvents)
                HookPropertyChanged(item);
            OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, index));
        }

        #endregion


        #region IBindingList

        [field: NonSerialized]
        public event ListChangedEventHandler ListChanged;

        private void OnListChanged(ListChangedEventArgs e) => ListChanged?.Invoke(this, e);

        private void HookPropertyChanged(T item)
        {
            if (item is INotifyPropertyChanged inpc)
                inpc.PropertyChanged += Child_PropertyChanged;
        }

        private void UnhookPropertyChanged(T item)
        {
            if (item is INotifyPropertyChanged inpc)
                inpc.PropertyChanged -= Child_PropertyChanged;
        }

        private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender == null || e == null || string.IsNullOrEmpty(e.PropertyName))
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            else
            {
                T item;
                try
                {
                    item = (T)sender;
                }
                catch (InvalidCastException)
                {
                    OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
                    return;
                }
                int pos = lastChangeIndex;
                if (pos < 0 || pos >= Count || !this[pos].Equals(item))
                {
                    pos = IndexOf(item);
                    lastChangeIndex = pos;
                }
                if (pos == -1)
                {
                    UnhookPropertyChanged(item);
                    OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
                }
                else
                {
                    if (null == itemTypeProperties)
                    {
                        itemTypeProperties = TypeDescriptor.GetProperties(typeof(T));
                    }
                    PropertyDescriptor pd = itemTypeProperties.Find(e.PropertyName, true);
                    ListChangedEventArgs args = new ListChangedEventArgs(ListChangedType.ItemChanged, pos, pd);
                    OnListChanged(args);
                }
            }
        }

        object IBindingList.AddNew() => throw new NotSupportedException();
        bool IBindingList.AllowNew => false;
        bool IBindingList.AllowEdit => true;
        bool IBindingList.AllowRemove => true;
        bool IBindingList.SupportsChangeNotification => true;
        bool IBindingList.SupportsSearching => false;
        bool IBindingList.SupportsSorting => false;
        bool IBindingList.IsSorted => false;
        PropertyDescriptor IBindingList.SortProperty => null;
        ListSortDirection IBindingList.SortDirection => ListSortDirection.Ascending;
        void IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction) => throw new NotSupportedException();
        void IBindingList.RemoveSort() => throw new NotSupportedException();
        int IBindingList.Find(PropertyDescriptor prop, object key) => throw new NotSupportedException();
        void IBindingList.AddIndex(PropertyDescriptor prop) { }
        void IBindingList.RemoveIndex(PropertyDescriptor prop) { }

        #endregion


        #region IRaiseItemChangedEvents

        bool IRaiseItemChangedEvents.RaisesItemChangedEvents => raiseItemChangedEvents;

        #endregion


        public void ResetBindings() => FireListChanged(ListChangedType.Reset, -1);

        private void FireListChanged(ListChangedType type, int index)
        {
            // todo: fix it
            //if (raiseListChangedEvents)
            //{
            OnListChanged(new ListChangedEventArgs(type, index));
            //}
        }
    }
}
