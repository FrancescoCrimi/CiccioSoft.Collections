// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace CiccioSoft.Collections
{
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    [Serializable]
    public class ObservableCollection<T> : ListBase<T>, IList<T>, IList, IReadOnlyList<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        private SimpleMonitor? _monitor; // Lazily allocated only when a subclass calls BlockReentrancy() or during serialization. Do not rename (binary serialization)

        [NonSerialized]
        private int _blockReentrancyCount;

        #region Constructors

        public ObservableCollection()
        {
        }

        public ObservableCollection(IEnumerable<T> collection) : base(collection)
        {
        }

        public ObservableCollection(int capacity) : base(capacity)
        {
        }

        #endregion


        #region Overrides Method

        /// <summary>
        /// Called by base class Collection&lt;T&gt; when the list is being cleared;
        /// raises a CollectionChanged event to any listeners.
        /// </summary>
        protected override void ClearItems()
        {
            CheckReentrancy();

            base.ClearItems();

            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionReset();
        }

        /// <summary>
        /// Called by base class Collection&lt;T&gt; when an item is added to list;
        /// raises a CollectionChanged event to any listeners.
        /// </summary>
        protected override void InsertItem(int index, T item)
        {
            CheckReentrancy();
            base.InsertItem(index, item);

            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Add, item, index);
        }

        /// <summary>
        /// Called by base class Collection&lt;T&gt; when an item is removed from list;
        /// raises a CollectionChanged event to any listeners.
        /// </summary>
        protected override void RemoveItem(int index)
        {
            CheckReentrancy();
            T removedItem = this[index];
            base.RemoveItem(index);

            OnCountPropertyChanged();
            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Remove, removedItem, index);
        }

        /// <summary>
        /// Called by base class Collection&lt;T&gt; when an item is set in list;
        /// raises a CollectionChanged event to any listeners.
        /// </summary>
        protected override void SetItem(int index, T item)
        {
            CheckReentrancy();
            T originalItem = this[index];
            base.SetItem(index, item);

            OnIndexerPropertyChanged();
            OnCollectionChanged(NotifyCollectionChangedAction.Replace, originalItem, item, index);
        }

        #endregion


        #region PropertyChanged

        /// <summary>
        /// PropertyChanged event (per <see cref="INotifyPropertyChanged" />).
        /// </summary>
        [field: NonSerialized]
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Raises a PropertyChanged event (per <see cref="INotifyPropertyChanged" />).
        /// </summary>
        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Helper to raise a PropertyChanged event for the Count property
        /// </summary>
        private void OnCountPropertyChanged() => OnPropertyChanged(EventArgsCache.CountPropertyChanged);

        /// <summary>
        /// Helper to raise a PropertyChanged event for the Indexer property
        /// </summary>
        private void OnIndexerPropertyChanged() => OnPropertyChanged(EventArgsCache.IndexerPropertyChanged);

        #endregion


        #region CollectionChanged

        /// <summary>
        /// Occurs when the collection changes, either by adding or removing an item.
        /// </summary>
        [field: NonSerialized]
        public virtual event NotifyCollectionChangedEventHandler? CollectionChanged;

        /// <summary> Check and assert for reentrant attempts to change this collection. </summary>
        /// <exception cref="InvalidOperationException"> raised when changing the collection
        /// while another collection change is still being notified to other listeners </exception>
        private void CheckReentrancy()
        {
            if (_blockReentrancyCount > 0)
            {
                // we can allow changes if there's only one listener - the problem
                // only arises if reentrant changes make the original event args
                // invalid for later listeners.  This keeps existing code working
                // (e.g. Selector.SelectedItems).
                if (CollectionChanged?.GetInvocationList().Length > 1)
                    throw new InvalidOperationException("Cannot change ObservableCollection during a CollectionChanged event.");
            }
        }

        /// <summary>
        /// Raise CollectionChanged event to any listeners.
        /// </summary>
        private void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            NotifyCollectionChangedEventHandler? handler = CollectionChanged;
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

        /// <summary>
        /// Helper to raise CollectionChanged event to any listeners
        /// </summary>
        private void OnCollectionChanged(NotifyCollectionChangedAction action, object? item, int index)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item, index));
        }

        /// <summary>
        /// Helper to raise CollectionChanged event to any listeners
        /// </summary>
        private void OnCollectionChanged(NotifyCollectionChangedAction action, object? item, int index, int oldIndex)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item, index, oldIndex));
        }

        /// <summary>
        /// Helper to raise CollectionChanged event to any listeners
        /// </summary>
        private void OnCollectionChanged(NotifyCollectionChangedAction action, object? oldItem, object? newItem, int index)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, newItem, oldItem, index));
        }

        /// <summary>
        /// Helper to raise CollectionChanged event with action == Reset to any listeners
        /// </summary>
        private void OnCollectionReset() => OnCollectionChanged(EventArgsCache.ResetCollectionChanged);

        #endregion


        #region Serializable

        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            EnsureMonitorInitialized();
            _monitor!._busyCount = _blockReentrancyCount;
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

        #endregion


        #region Private

        private SimpleMonitor EnsureMonitorInitialized() => _monitor ??= new SimpleMonitor(this);

        // this class helps prevent reentrant calls
        [Serializable]
        private sealed class SimpleMonitor : IDisposable
        {
            internal int _busyCount; // Only used during (de)serialization to maintain compatibility with desktop. Do not rename (binary serialization)

            [NonSerialized]
            internal ObservableCollection<T> _collection;

            public SimpleMonitor(ObservableCollection<T> collection)
            {
                Debug.Assert(collection != null);
                _collection = collection;
            }

            public void Dispose() => _collection._blockReentrancyCount--;
        }

        #endregion
    }
}
