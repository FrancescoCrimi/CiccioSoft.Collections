// Licensed to the .NET Foundation under one or more agreements.
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
        private List<T> genericList;

        private bool raiseItemChangedEvents;
        [NonSerialized]
        private PropertyDescriptorCollection _itemTypeProperties;
        [NonSerialized]
        private int _lastChangeIndex = -1;

        private SimpleMonitor _monitor;
        [NonSerialized]
        private int _blockReentrancyCount;


        #region Constructors

        public CiccioSet()
        {
            items = new HashSet<T>();
            genericList = new List<T>(items);
            Initialize();
        }
        public CiccioSet(IEnumerable<T> collection)
        {
            items = new HashSet<T>(collection);
            genericList = new List<T>(items);
            Initialize();
        }
        public CiccioSet(IEqualityComparer<T> comparer)
        {
            items = new HashSet<T>(comparer);
            genericList = new List<T>(items);
            Initialize();
        }
        public CiccioSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
        {
            items = new HashSet<T>(collection, comparer);
            genericList = new List<T>(items);
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


        public ISet<T> Items => items;


        #region ISet

        public int Count => items.Count;

        public bool IsReadOnly => ((ICollection<T>)items).IsReadOnly;

        public bool Add(T item)
        {
            if (items.Contains(item)) return false;

            CheckReentrancy();
            items.Add(item);
            genericList = new List<T>(items);
            int index = genericList.IndexOf(item);
            if (raiseItemChangedEvents)
                HookPropertyChanged(item);

            OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
            return true;
        }

        public void Clear()
        {
            if (items.Count == 0) return;

            CheckReentrancy();
            if (raiseItemChangedEvents)
            {
                foreach (T item in items)
                {
                    UnhookPropertyChanged(item);
                }
            }
            items.Clear();
            genericList.Clear();

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
        }

        public bool Contains(T item) => items.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);

        public void ExceptWith(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.ExceptWith(other);
            if (copy.Count == items.Count) return;
            var removed = items.Where(i => !copy.Contains(i)).ToList();

            CheckReentrancy();
            items = copy;
            genericList = new List<T>(items);

            if (raiseItemChangedEvents)
            {
                foreach (T item in removed)
                {
                    UnhookPropertyChanged(item);
                }
            }

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, removed));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
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
            genericList = new List<T>(items);

            if (raiseItemChangedEvents)
            {
                foreach (T item in removed)
                {
                    UnhookPropertyChanged(item);
                }
            }

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, removed));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
        }

        public bool IsProperSubsetOf(IEnumerable<T> other) => items.IsProperSubsetOf(other);

        public bool IsProperSupersetOf(IEnumerable<T> other) => items.IsProperSupersetOf(other);

        public bool IsSubsetOf(IEnumerable<T> other) => items.IsSubsetOf(other);

        public bool IsSupersetOf(IEnumerable<T> other) => items.IsSupersetOf(other);

        public bool Overlaps(IEnumerable<T> other) => items.Overlaps(other);

        public bool Remove(T item)
        {
            if (!items.Contains(item)) return false;

            if (raiseItemChangedEvents)
                UnhookPropertyChanged(item);
            int index = genericList.IndexOf(item);

            CheckReentrancy();
            items.Remove(item);
            genericList = new List<T>(items);

            OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
            return true;
        }

        public bool SetEquals(IEnumerable<T> other) => items.SetEquals(other);

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.SymmetricExceptWith(other);
            var removed = items.Where(i => !copy.Contains(i)).ToList();
            var added = copy.Where(i => !items.Contains(i)).ToList();
            if (removed.Count == 0 && added.Count == 0) return;

            CheckReentrancy();
            items = copy;
            genericList = new List<T>(items);
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

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, added, removed));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
        }

        public void UnionWith(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.UnionWith(other);
            if (copy.Count == items.Count) return;
            var added = copy.Where(i => !items.Contains(i)).ToList();

            CheckReentrancy();
            items = copy;
            genericList = new List<T>(items);
            if (raiseItemChangedEvents)
            {
                foreach (T item in added)
                {
                    HookPropertyChanged(item);
                }
            }

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, added));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
        }

        void ICollection<T>.Add(T item) => Add(item);

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();

        #endregion


        #region INotifyCollectionChanged

        [field: NonSerialized]
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            NotifyCollectionChangedEventHandler handler = CollectionChanged;
            if (handler != null)
            {
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

        protected void CheckReentrancy()
        {
            if (_blockReentrancyCount > 0)
            {
                if (CollectionChanged?.GetInvocationList().Length > 1)
                    throw new InvalidOperationException("ObservableCollection Reentrancy Not Allowed");
            }
        }

        protected IDisposable BlockReentrancy()
        {
            _blockReentrancyCount++;
            return EnsureMonitorInitialized();
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
            internal CiccioSet<T> _collection;

            public SimpleMonitor(CiccioSet<T> collection)
            {
                //Debug.Assert(collection != null);
                _collection = collection;
            }

            public void Dispose() => _collection._blockReentrancyCount--;
        }

        #endregion


        #region INotifyPropertyChanged

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        #endregion


        #region IList

        int ICollection.Count => items.Count;
        bool ICollection.IsSynchronized => false;
        object ICollection.SyncRoot => this;
        bool IList.IsFixedSize => false;
        bool IList.IsReadOnly => true;
        object IList.this[int index] { get => genericList[index]; set => throw new NotSupportedException(); }
        void ICollection.CopyTo(Array array, int index) => ((IList)genericList).CopyTo(array, index);
        int IList.Add(object value) => throw new NotSupportedException();
        void IList.Clear() => throw new NotSupportedException();
        bool IList.Contains(object value) => ((IList)genericList).Contains(value);
        int IList.IndexOf(object value) => ((IList)genericList).IndexOf((T)value);
        void IList.Insert(int index, object value) => throw new NotSupportedException();
        void IList.Remove(object value) => throw new NotSupportedException();
        void IList.RemoveAt(int index) => throw new NotSupportedException();

        #endregion


        #region IBindingList

        [field: NonSerialized]
        public event ListChangedEventHandler ListChanged;

        private void OnListChanged(ListChangedEventArgs e)
        {
            ListChanged?.Invoke(this, e);
        }

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
            {
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
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
                    OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
                    return;
                }
                int pos = _lastChangeIndex;
                if (pos < 0 || pos >= Count || !this.ToList()[pos].Equals(item))
                {
                    pos = this.ToList().IndexOf(item);
                    _lastChangeIndex = pos;
                }
                if (pos == -1)
                {
                    UnhookPropertyChanged(item);
                    OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
                }
                else
                {
                    if (null == _itemTypeProperties)
                    {
                        _itemTypeProperties = TypeDescriptor.GetProperties(typeof(T));
                    }
                    PropertyDescriptor pd = _itemTypeProperties.Find(e.PropertyName, true);
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
