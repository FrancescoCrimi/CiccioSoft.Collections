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
    public class ObservableSet<T> : ISet<T>, INotifyCollectionChanged, INotifyPropertyChanged, IReadOnlyCollection<T>
    {
        private HashSet<T> items;

        private SimpleMonitor _monitor;
        [NonSerialized]
        private int _blockReentrancyCount;

        #region Constructors

        public ObservableSet() => items = new HashSet<T>();
        public ObservableSet(IEnumerable<T> collection) => items = new HashSet<T>(collection);
        public ObservableSet(IEqualityComparer<T> comparer) => items = new HashSet<T>(comparer);
        public ObservableSet(IEnumerable<T> collection, IEqualityComparer<T> comparer) => items = new HashSet<T>(collection, comparer);

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
            int index = items.ToList().IndexOf(item);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
            return true;
        }

        public void Clear()
        {
            if (items.Count == 0) return;
            CheckReentrancy();
            items.Clear();
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
            CheckReentrancy();
            var removed = items.Where(i => !copy.Contains(i)).ToList();
            items = copy;
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, removed));
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
        }

        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

        public void IntersectWith(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.IntersectWith(other);
            if (copy.Count == items.Count) return;
            CheckReentrancy();
            var removed = items.Where(i => !copy.Contains(i)).ToList();
            items = copy;
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
            int index = items.ToList().IndexOf(item);
            CheckReentrancy();
            items.Remove(item);
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
            internal ObservableSet<T> _collection;

            public SimpleMonitor(ObservableSet<T> collection)
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
