﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Francesco Crimi francrim@gmail.com

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;

namespace CiccioSoft.Collections.Generic
{
    [Serializable]
    [DebuggerTypeProxy(typeof(CollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class CiccioSet<T> : ISet<T>, IBindingList, IRaiseItemChangedEvents, INotifyCollectionChanged, INotifyPropertyChanged, IReadOnlyCollection<T>
    {
        private HashSet<T> items;


        private bool raiseItemChangedEvents; // Do not rename (binary serialization)

        [NonSerialized]
        private PropertyDescriptorCollection _itemTypeProperties;

        [NonSerialized]
        private PropertyChangedEventHandler _propertyChangedEventHandler;

        [NonSerialized]
        private ListChangedEventHandler _onListChanged;

        [NonSerialized]
        private int _lastChangeIndex = -1;


        private SimpleMonitor _monitor;

        [NonSerialized]
        private int _blockReentrancyCount;


        #region Constructors

        public CiccioSet()
        {
            items = new HashSet<T>();
            Initialize();
        }
        public CiccioSet(IEnumerable<T> collection)
        {
            items = new HashSet<T>(collection);
            Initialize();
        }
        public CiccioSet(IEqualityComparer<T> comparer)
        {
            items = new HashSet<T>(comparer);
            Initialize();
        }
        public CiccioSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
        {
            items = new HashSet<T>(collection, comparer);
            Initialize();
        }

        private void Initialize()
        {
            if (typeof(INotifyPropertyChanged).IsAssignableFrom(typeof(T)))
            {
                raiseItemChangedEvents = true;
                foreach (T item in items)
                {
                    HookPropertyChanged(item);
                }
            }
        }

        #endregion

        #region ISet

        public int Count => items.Count;

        public bool IsReadOnly => ((ICollection<T>)items).IsReadOnly;

        public bool Add(T item)
        {
            CheckReentrancy();
            bool retValue = items.Add(item);
            if (retValue)
            {
                int index = items.ToList().IndexOf(item);
                if (raiseItemChangedEvents)
                {
                    HookPropertyChanged(item);
                }
                FireListChanged(ListChangedType.ItemAdded, index);
                OnCountPropertyChanged();
                OnIndexerPropertyChanged();
                OnCollectionChanged(NotifyCollectionChangedAction.Add, item, index);
            }
            return retValue;
        }

        public void Clear()
        {
            if (items.Count == 0)
            {
                return;
            }
            CheckReentrancy();
            if (raiseItemChangedEvents)
            {
                foreach (T item in items)
                {
                    UnhookPropertyChanged(item);
                }
            }
            items.Clear();
            FireListChanged(ListChangedType.Reset, -1);
            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionReset();
        }

        public bool Contains(T item) => items.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);

        public void ExceptWith(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.ExceptWith(other);
            if (copy.Count == items.Count)
            {
                return;
            }
            CheckReentrancy();
            var removed = items.Where(i => !copy.Contains(i)).ToList();
            items = copy;
            if (raiseItemChangedEvents)
            {
                foreach (T item in removed)
                {
                    UnhookPropertyChanged(item);
                }
            }
            FireListChanged(ListChangedType.Reset, -1);
            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, Array.Empty<object>(), removed));
        }

        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

        public void IntersectWith(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.IntersectWith(other);
            if (copy.Count == items.Count) return;
            var removed = items.Where(i => !copy.Contains(i)).ToList();

            CheckReentrancy();
            items = copy;

            if (raiseItemChangedEvents)
            {
                foreach (T item in removed)
                {
                    UnhookPropertyChanged(item);
                }
            }
            FireListChanged(ListChangedType.Reset, -1);
            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, Array.Empty<object>(), removed));
        }

        public bool IsProperSubsetOf(IEnumerable<T> other) => items.IsProperSubsetOf(other);

        public bool IsProperSupersetOf(IEnumerable<T> other) => items.IsProperSupersetOf(other);

        public bool IsSubsetOf(IEnumerable<T> other) => items.IsSubsetOf(other);

        public bool IsSupersetOf(IEnumerable<T> other) => items.IsSupersetOf(other);

        public bool Overlaps(IEnumerable<T> other) => items.Overlaps(other);

        public bool Remove(T item)
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
            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Remove, item, index);
            return true;
        }

        public bool SetEquals(IEnumerable<T> other) => items.SetEquals(other);

        public void SymmetricExceptWith(IEnumerable<T> other)
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
            CheckReentrancy();
            items = copy;
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
            FireListChanged(ListChangedType.Reset, -1);
            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, added, removed));
        }

        public void UnionWith(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.UnionWith(other);
            if (copy.Count == items.Count)
            {
                return;
            }
            var added = copy.Where(i => !items.Contains(i)).ToList();
            CheckReentrancy();
            items = copy;
            if (raiseItemChangedEvents)
            {
                foreach (T item in added)
                {
                    HookPropertyChanged(item);
                }
            }
            FireListChanged(ListChangedType.Reset, -1);
            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, added, Array.Empty<object>()));
        }

        void ICollection<T>.Add(T item) => Add(item);

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();

        #endregion

        #region IList

        int ICollection.Count => items.Count;

        bool ICollection.IsSynchronized => false;

        object ICollection.SyncRoot => this;

        bool IList.IsFixedSize => false;

        bool IList.IsReadOnly => true;

        object IList.this[int index] { get => items.ToList()[index]; set => throw new NotSupportedException(); }

        void ICollection.CopyTo(Array array, int index) => ((IList)items.ToList()).CopyTo(array, index);

        int IList.Add(object value) => throw new NotSupportedException();

        void IList.Clear() => throw new NotSupportedException();

        bool IList.Contains(object value) => ((IList)items.ToList()).Contains(value);

        int IList.IndexOf(object value) => ((IList)items.ToList()).IndexOf((T)value);

        void IList.Insert(int index, object value) => throw new NotSupportedException();

        void IList.Remove(object value) => throw new NotSupportedException();

        void IList.RemoveAt(int index) => throw new NotSupportedException();

        #endregion

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

                if (pos < 0 || pos >= Count || !items.ToList()[pos].Equals(item))
                {
                    pos = items.ToList().IndexOf(item);
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
            internal CiccioSet<T> _collection;

            public SimpleMonitor(CiccioSet<T> collection)
            {
                _collection = collection;
            }

            public void Dispose() => _collection._blockReentrancyCount--;
        }

        protected ISet<T> Items => items;
    }
}
