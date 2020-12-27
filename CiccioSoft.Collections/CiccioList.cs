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

        private bool raiseItemChangedEvents; // Do not rename (binary serialization)

        [NonSerialized]
        private PropertyDescriptorCollection _itemTypeProperties;

        [NonSerialized]
        private PropertyChangedEventHandler _propertyChangedEventHandler;

        [NonSerialized]
        private ListChangedEventHandler _onListChanged;

        [NonSerialized]
        private int _lastChangeIndex = -1;


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

        #region Collection<T> overrides

        protected override void ClearItems()
        {
            CheckReentrancy();
            if (raiseItemChangedEvents)
            {
                foreach (T item in Items)
                {
                    UnhookPropertyChanged(item);
                }
            }
            base.ClearItems();
            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionReset();
            FireListChanged(ListChangedType.Reset, -1);
        }

        protected override void InsertItem(int index, T item)
        {
            CheckReentrancy();
            base.InsertItem(index, item);
            if (raiseItemChangedEvents)
            {
                HookPropertyChanged(item);
            }
            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Add, item, index);
            FireListChanged(ListChangedType.ItemAdded, index);
        }

        protected override void RemoveItem(int index)
        {
            CheckReentrancy();
            if (raiseItemChangedEvents)
            {
                UnhookPropertyChanged(this[index]);
            }
            T removedItem = this[index];
            base.RemoveItem(index);
            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Remove, removedItem, index);
            FireListChanged(ListChangedType.ItemDeleted, index);
        }

        protected override void SetItem(int index, T item)
        {
            CheckReentrancy();
            if (raiseItemChangedEvents)
            {
                UnhookPropertyChanged(this[index]);
            }
            T originalItem = this[index];
            base.SetItem(index, item);
            if (raiseItemChangedEvents)
            {
                HookPropertyChanged(item);
            }
            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Replace, originalItem, item, index);
            FireListChanged(ListChangedType.ItemChanged, index);
        }

        #endregion Collection<T> overrides

        #region INotifyPropertyChanged

        [field: NonSerialized]
        protected virtual event PropertyChangedEventHandler PropertyChanged;

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add => PropertyChanged += value;
            remove => PropertyChanged -= value;
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        private void OnCountPropertyChanged() => OnPropertyChanged(EventArgsCache.CountPropertyChanged);

        private void OnIndexerPropertyChanged() => OnPropertyChanged(EventArgsCache.IndexerPropertyChanged);

        #endregion

        #region INotifyCollectionChanged

        [field: NonSerialized]
        public virtual event NotifyCollectionChangedEventHandler CollectionChanged;

        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            NotifyCollectionChangedEventHandler handler = CollectionChanged;
            if (handler != null)
            {
                // Not calling BlockReentrancy() here to avoid the SimpleMonitor allocation.
                _blockReentrancyCount++;
                try
                {
                    handler(this, e);
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
                if (CollectionChanged?.GetInvocationList().Length > 1)
                    throw new InvalidOperationException("ObservableCollection Reentrancy Not Allowed");
            }
        }

        private void OnCollectionChanged(NotifyCollectionChangedAction action, object item, int index)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item, index));
        }

        private void OnCollectionChanged(NotifyCollectionChangedAction action, object oldItem, object newItem, int index)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, newItem, oldItem, index));
        }

        private void OnCollectionReset() => OnCollectionChanged(EventArgsCache.ResetCollectionChanged);

        private SimpleMonitor EnsureMonitorInitialized()
        {
            return _monitor ?? (_monitor = new SimpleMonitor(this));
        }

        #endregion

        #region ListChanged event

        public event ListChangedEventHandler ListChanged
        {
            add => _onListChanged += value;
            remove => _onListChanged -= value;
        }

        protected virtual void OnListChanged(ListChangedEventArgs e)
            => _onListChanged?.Invoke(this, e);

        private void ResetBindings()
            => FireListChanged(ListChangedType.Reset, -1);

        private void FireListChanged(ListChangedType type, int index)
        {
            OnListChanged(new ListChangedEventArgs(type, index));
        }

        #endregion

        #region Property Change Support

        private void HookPropertyChanged(T item)
        {
            if (item is INotifyPropertyChanged inpc)
            {
                if (_propertyChangedEventHandler == null)
                {
                    _propertyChangedEventHandler = new PropertyChangedEventHandler(Child_PropertyChanged);
                }
                inpc.PropertyChanged += _propertyChangedEventHandler;
            }
        }

        private void UnhookPropertyChanged(T item)
        {
            if (item is INotifyPropertyChanged inpc && _propertyChangedEventHandler != null)
            {
                inpc.PropertyChanged -= _propertyChangedEventHandler;
            }
        }

        private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender == null || e == null || string.IsNullOrEmpty(e.PropertyName))
            {
                ResetBindings();
            }
            else
            {
                T item;

                try
                {
                    item = (T)sender;
                }
                catch (InvalidCastException)
                {
                    ResetBindings();
                    return;
                }

                int pos = _lastChangeIndex;

                if (pos < 0 || pos >= Count || !this[pos].Equals(item))
                {
                    pos = IndexOf(item);
                    _lastChangeIndex = pos;
                }

                if (pos == -1)
                {
                    UnhookPropertyChanged(item);
                    ResetBindings();
                }
                else
                {
                    if (null == _itemTypeProperties)
                    {
                        _itemTypeProperties = TypeDescriptor.GetProperties(typeof(T));
                        Debug.Assert(_itemTypeProperties != null);
                    }
                    PropertyDescriptor pd = _itemTypeProperties.Find(e.PropertyName, true);
                    ListChangedEventArgs args = new ListChangedEventArgs(ListChangedType.ItemChanged, pos, pd);
                    OnListChanged(args);
                }
            }
        }

        #endregion

        #region IBindingList

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

        void IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction)
        {
            throw new NotSupportedException();
        }

        void IBindingList.RemoveSort()
        {
            throw new NotSupportedException();
        }

        int IBindingList.Find(PropertyDescriptor prop, object key)
        {
            throw new NotSupportedException();
        }

        void IBindingList.AddIndex(PropertyDescriptor prop)
        {
            // Not supported
        }

        void IBindingList.RemoveIndex(PropertyDescriptor prop)
        {
            // Not supported
        }

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

        [Serializable]
        private sealed class SimpleMonitor : IDisposable
        {
            internal int _busyCount; // Only used during (de)serialization to maintain compatibility with desktop. Do not rename (binary serialization)

            [NonSerialized]
            internal CiccioList<T> _collection;

            public SimpleMonitor(CiccioList<T> collection)
            {
                Debug.Assert(collection != null);
                _collection = collection;
            }

            public void Dispose() => _collection._blockReentrancyCount--;
        }

        public bool IsReadOnly => Items.IsReadOnly;
    }
}
