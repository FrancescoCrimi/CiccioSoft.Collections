// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;

namespace CiccioSoft.Collections
{
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class ObservableHashSet<T> : SetBase<T>, ICollection<T>, ISet<T>, IReadOnlyCollection<T>, IReadOnlySet<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        //private SimpleMonitor? _monitor; // Lazily allocated only when a subclass calls BlockReentrancy() or during serialization. Do not rename (binary serialization)

        [NonSerialized]
        private int _blockReentrancyCount;

        #region Constructors

        public ObservableHashSet()
        {
        }

        public ObservableHashSet(IEqualityComparer<T>? comparer) : base(comparer)
        {
        }

#if NET6_0_OR_GREATER

        public ObservableHashSet(int capacity) : base(capacity)
        {
        }

#endif

        public ObservableHashSet(IEnumerable<T> collection) : base(collection)
        {
        }

        public ObservableHashSet(IEnumerable<T> collection, IEqualityComparer<T>? comparer) : base(collection, comparer)
        {
        }

#if NET6_0_OR_GREATER

        public ObservableHashSet(int capacity, IEqualityComparer<T>? comparer) : base(capacity, comparer)
        {
        }

#endif

        #endregion

        #region Overrides Method

        protected override bool AddItem(T item)
        {
            if (items.Contains(item))
            {
                return false;
            }

            CheckReentrancy();

            items.Add(item);

            OnCollectionChanged(NotifyCollectionChangedAction.Add, item);
            OnCountPropertyChanged();

            return true;
        }

        protected override void ClearItems()
        {
            if (items.Count == 0)
            {
                return;
            }

            CheckReentrancy();
            var removed = this.ToList();

            items.Clear();

            OnCollectionChanged(EventArgsCache.NoItems, removed);
            OnCountPropertyChanged();
        }

        protected override void ExceptWithItems(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.ExceptWith(other);
            if (copy.Count == items.Count)
            {
                return;
            }
            var removed = items.Where(i => !copy.Contains(i)).ToList();

            CheckReentrancy();

            items = copy;

            OnCollectionChanged(EventArgsCache.NoItems, removed);
            OnCountPropertyChanged();
        }

        protected override void IntersectWithItems(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.IntersectWith(other);
            if (copy.Count == items.Count)
            {
                return;
            }
            var removed = items.Where(i => !copy.Contains(i)).ToList();

            CheckReentrancy();

            items = copy;

            OnCollectionChanged(EventArgsCache.NoItems, removed);
            OnCountPropertyChanged();
        }

        protected override bool RemoveItem(T item)
        {
            if (!items.Contains(item))
            {
                return false;
            }

            CheckReentrancy();

            items.Remove(item);

            OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);
            OnCountPropertyChanged();

            return true;
        }

        protected override void SymmetricExceptWithItems(IEnumerable<T> other)
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

            OnCollectionChanged(added, removed);
            OnCountPropertyChanged();
        }

        protected override void UnionWithItems(IEnumerable<T> other)
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

            OnCollectionChanged(added, EventArgsCache.NoItems);
            OnCountPropertyChanged();
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
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Helper to raise a PropertyChanged event for the Count property
        /// </summary>
        private void OnCountPropertyChanged()
        {
            OnPropertyChanged(EventArgsCache.CountPropertyChanged);
        }

        #endregion

        #region CollectionChanged

        /// <summary>
        /// Occurs when the collection changes, either by adding or removing an item.
        /// </summary>
        [field: NonSerialized]
        public event NotifyCollectionChangedEventHandler? CollectionChanged;

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
        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (CollectionChanged != null)
            {
                // Not calling BlockReentrancy() here to avoid the SimpleMonitor allocation.
                _blockReentrancyCount++;
                try
                {
                    CollectionChanged.Invoke(this, e);
                }
                finally
                {
                    _blockReentrancyCount--;
                }
            }
        }

        private void OnCollectionChanged(NotifyCollectionChangedAction action, object? item)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item));
        }

        private void OnCollectionChanged(IList newItems, IList oldItems)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newItems, oldItems));
        }

        #endregion

        #region Serializable

        //[OnSerializing]
        //private void OnSerializing(StreamingContext context)
        //{
        //    EnsureMonitorInitialized();
        //    _monitor!._busyCount = _blockReentrancyCount;
        //}

        //[OnDeserialized]
        //private void OnDeserialized(StreamingContext context)
        //{
        //    if (_monitor != null)
        //    {
        //        _blockReentrancyCount = _monitor._busyCount;
        //        _monitor._collection = this;
        //    }
        //}

        #endregion

        #region Private

        //private SimpleMonitor EnsureMonitorInitialized() => _monitor ??= new SimpleMonitor(this);

        //// this class helps prevent reentrant calls
        //[Serializable]
        //private sealed class SimpleMonitor : IDisposable
        //{
        //    internal int _busyCount; // Only used during (de)serialization to maintain compatibility with desktop. Do not rename (binary serialization)

        //    [NonSerialized]
        //    internal ObservableSet<T> _collection;

        //    public SimpleMonitor(ObservableSet<T> collection)
        //    {
        //        Debug.Assert(collection != null);
        //        _collection = collection;
        //    }

        //    public void Dispose() => _collection._blockReentrancyCount--;
        //}

        #endregion
    }
}
