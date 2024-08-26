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
    public class ObservableList<T> : Collection<T>, INotifyCollectionChanged, INotifyPropertyChanged, IReadOnlyList<T>
    {
        private SimpleMonitor _monitor;

        [NonSerialized]
        private int _blockReentrancyCount;

        #region Constructors

        public ObservableList() : base()
        {
        }

        public ObservableList(IEnumerable<T> collection) : base(new List<T>(collection))
        {
        }

        public ObservableList(int capacity) : base(new List<T>(capacity))
        {
        }

        #endregion

        #region Collection<T> overrides

        protected override void ClearItems()
        {
            CheckReentrancy();
            base.ClearItems();
            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionReset();
        }

        protected override void RemoveItem(int index)
        {
            CheckReentrancy();
            T removedItem = this[index];
            base.RemoveItem(index);
            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Remove, removedItem, index);
        }

        protected override void InsertItem(int index, T item)
        {
            CheckReentrancy();
            base.InsertItem(index, item);
            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Add, item, index);
        }

        protected override void SetItem(int index, T item)
        {
            CheckReentrancy();
            T originalItem = this[index];
            base.SetItem(index, item);
            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Replace, originalItem, item, index);
        }

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
                    throw new InvalidOperationException("Cannot change ObservableCollection during a CollectionChanged event.");
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
            internal ObservableList<T> _collection;

            public SimpleMonitor(ObservableList<T> collection)
            {
                _collection = collection;
            }

            public void Dispose() => _collection._blockReentrancyCount--;
        }

        public bool IsReadOnly => Items.IsReadOnly;
    }
}
