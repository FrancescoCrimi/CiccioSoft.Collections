// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Francesco Crimi francrim@gmail.com

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CiccioSoft.Collections.Generic
{
    [Serializable]
    [DebuggerTypeProxy(typeof(CollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class CiccioList<T> : Collection<T>, IBindingList, IRaiseItemChangedEvents, INotifyCollectionChanged, INotifyPropertyChanged, IReadOnlyList<T>
    {
        private SimpleMonitor _monitor;
        [NonSerialized]
        private int _blockReentrancyCount;

        private bool raiseItemChangedEvents;
        [NonSerialized]
        private PropertyDescriptorCollection itemTypeProperties;
        [NonSerialized]
        private int lastChangeIndex = -1;


        #region Constructors

        public CiccioList() : base() { Initialize(); }
        //public CiccioList(IList<T> list) : base(list) { Initialize(); }
        public CiccioList(IEnumerable<T> collection) : base(new List<T>(collection)) { Initialize(); }
        public CiccioList(int capacity) : base(new List<T>(capacity)) { Initialize(); }

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
            CheckReentrancy();
            if (raiseItemChangedEvents)
            {
                foreach (T item in this.Items)
                {
                    UnhookPropertyChanged(item);
                }
            }
            base.ClearItems();
            OnPropertyChanged("Count");
            OnPropertyChanged("Item[]");
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            OnListChanged(ListChangedType.Reset, -1);
        }

        protected override void InsertItem(int index, T item)
        {
            CheckReentrancy();
            base.InsertItem(index, item);
            if (raiseItemChangedEvents)
                HookPropertyChanged(item);
            OnPropertyChanged("Count");
            OnPropertyChanged("Item[]");
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index));
            OnListChanged(ListChangedType.ItemAdded, index);
        }

        protected override void RemoveItem(int index)
        {
            CheckReentrancy();
            if (raiseItemChangedEvents)
                UnhookPropertyChanged(this[index]);
            T removedItem = this[index];
            base.RemoveItem(index);
            OnPropertyChanged("Count");
            OnPropertyChanged("Item[]");
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, removedItem, index));
            OnListChanged(ListChangedType.ItemDeleted, index);
        }

        protected override void SetItem(int index, T item)
        {
            CheckReentrancy();
            if (raiseItemChangedEvents)
                UnhookPropertyChanged(this[index]);
            T originalItem = this[index];
            base.SetItem(index, item);
            if (this.raiseItemChangedEvents)
                HookPropertyChanged(item);
            OnPropertyChanged("Item[]");
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, item, originalItem, index));
            OnListChanged(ListChangedType.ItemChanged, index);
        }

        #endregion Collection<T> overrides


        #region INotifyPropertyChanged

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


        #region INotifyCollectionChanged

        [field: NonSerialized]
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (CollectionChanged != null)
            {
                _blockReentrancyCount++;
                try
                {
                    CollectionChanged(this, e);
                }
                finally
                {
                    _blockReentrancyCount--;
                }
            }
        }

        protected IDisposable BlockReentrancy()
        {
            _blockReentrancyCount++;
            return EnsureMonitorInitialized();
        }

        protected void CheckReentrancy()
        {
            if (_blockReentrancyCount > 0)
            {
                if ((CollectionChanged != null) && (CollectionChanged.GetInvocationList().Length > 1))
                    throw new InvalidOperationException("ObservableCollection Reentrancy Not Allowed");
            }
        }

        private SimpleMonitor EnsureMonitorInitialized()
        {
            return _monitor ?? (_monitor = new SimpleMonitor(this));
        }

        [Serializable]
        private sealed class SimpleMonitor : IDisposable
        {
            internal int _busyCount; // Only used during (de)serialization to maintain compatibility with desktop. Do not rename (binary serialization)

            [NonSerialized]
            internal CiccioList<T> _collection;

            public SimpleMonitor(CiccioList<T> collection)
            {
                //Debug.Assert(collection != null);
                _collection = collection;
            }

            public void Dispose() => _collection._blockReentrancyCount--;
        }

        #endregion


        #region IBindingList

        [field: NonSerialized]
        public event ListChangedEventHandler ListChanged;

        private void OnListChanged(ListChangedType type, int index)
        {
            ListChanged?.Invoke(this, new ListChangedEventArgs(type, index));
        }

        private void HookPropertyChanged(T item)
        {
            INotifyPropertyChanged inpc = (item as INotifyPropertyChanged);
            if (null != inpc)
                inpc.PropertyChanged += Child_PropertyChanged;
        }

        private void UnhookPropertyChanged(T item)
        {
            INotifyPropertyChanged inpc = (item as INotifyPropertyChanged);
            if (null != inpc)
                inpc.PropertyChanged -= Child_PropertyChanged;
        }

        private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender == null || e == null || string.IsNullOrEmpty(e.PropertyName))
                OnListChanged(ListChangedType.Reset, -1);
            else
            {
                T item;
                try
                {
                    item = (T)sender;
                }
                catch (InvalidCastException)
                {
                    OnListChanged(ListChangedType.Reset, -1);
                    return;
                }
                int pos = lastChangeIndex;
                if (pos < 0 || pos >= Count || !this[pos].Equals(item))
                {
                    pos = this.IndexOf(item);
                    lastChangeIndex = pos;
                }
                if (pos == -1)
                {
                    Debug.Fail("Item is no longer in our list but we are still getting change notifications.");
                    UnhookPropertyChanged(item);
                    OnListChanged(ListChangedType.Reset, -1);
                }
                else
                {
                    if (null == this.itemTypeProperties)
                    {
                        itemTypeProperties = TypeDescriptor.GetProperties(typeof(T));
                        Debug.Assert(itemTypeProperties != null);
                    }
                    PropertyDescriptor pd = itemTypeProperties.Find(e.PropertyName, true);
                    ListChangedEventArgs args = new ListChangedEventArgs(ListChangedType.ItemChanged, pos, pd);
                    ListChanged?.Invoke(this, args);
                }
            }
        }

        object IBindingList.AddNew() => throw new NotSupportedException();
        bool IBindingList.AllowNew  => false;
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


        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            EnsureMonitorInitialized();
            _monitor._busyCount = _blockReentrancyCount;
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            if (_monitor != null)
            {
                _blockReentrancyCount = _monitor._busyCount;
                _monitor._collection = this;
            }
        }
    }
}
