// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace CiccioSoft.Collections.Observable
{
    /// <summary>
    /// Represents a hash set collection that provides notifications when its contents change.
    /// <para>
    /// <see cref="ObservableHashSet{T}"/> extends <see cref="Core.HashSet{T}"/> and implements
    /// <see cref="INotifyCollectionChanged"/> and <see cref="INotifyPropertyChanged"/>,
    /// making it suitable for data binding scenarios where consumers need to react to
    /// additions, removals, or other modifications in real time.
    /// </para>
    /// <para>
    /// All mutating operations (such as Add, Remove, Union, Intersect, etc.) raise the
    /// appropriate <c>CollectionChanged</c> and <c>PropertyChanged</c> events, allowing
    /// observers to track changes to the set.
    /// </para>
    /// <para>
    /// The implementation of this class is inspired by the ObservableHashSet from the
    /// Entity Framework Core project:
    /// https://github.com/dotnet/efcore/blob/main/src/EFCore/ChangeTracking/ObservableHashSet.cs
    /// </para>
    /// </summary>
    /// <typeparam name="T">The type of elements in the set.</typeparam>
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class ObservableHashSet<T> : CiccioSoft.Collections.Core.HashSet<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        [NonSerialized]
        private int _blockReentrancyCount;

        #region Constructors

        public ObservableHashSet()
        {
        }

        public ObservableHashSet(IEqualityComparer<T>? comparer) : base(comparer)
        {
        }

#if NET472_OR_GREATER || NET6_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
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

#if NET472_OR_GREATER || NET6_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        public ObservableHashSet(int capacity, IEqualityComparer<T>? comparer) : base(capacity, comparer)
        {
        }
#endif

        #endregion

        #region Protected Override Methods

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

        protected override void ExceptWithItems(IEnumerable<T> other)
        {
            var copy = new System.Collections.Generic.HashSet<T>(items, items.Comparer);
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
            var copy = new System.Collections.Generic.HashSet<T>(items, items.Comparer);
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

        protected override void SymmetricExceptWithItems(IEnumerable<T> other)
        {
            var copy = new System.Collections.Generic.HashSet<T>(items, items.Comparer);
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
            var copy = new System.Collections.Generic.HashSet<T>(items, items.Comparer);
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

        #region INotifyPropertyChanged interface

        /// <summary>
        /// PropertyChanged event (per <see cref="INotifyPropertyChanged" />).
        /// </summary>
        event PropertyChangedEventHandler? INotifyPropertyChanged.PropertyChanged
        {
            add => PropertyChanged += value;
            remove => PropertyChanged -= value;
        }

        /// <summary>
        /// Raises a PropertyChanged event (per <see cref="INotifyPropertyChanged" />).
        /// </summary>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        /// <summary>
        /// PropertyChanged event (per <see cref="INotifyPropertyChanged" />).
        /// </summary>
        [field: NonSerialized]
        protected virtual event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Helper to raise a PropertyChanged event for the Count property
        /// </summary>
        private void OnCountPropertyChanged() => OnPropertyChanged(EventArgsCache.CountPropertyChanged);

        #endregion

        #region INotifyCollectionChanged interface

        /// <summary>
        /// Occurs when the collection changes, either by adding or removing an item.
        /// </summary>
        [field: NonSerialized]
        public virtual event NotifyCollectionChangedEventHandler? CollectionChanged;

        /// <summary>
        /// Raise CollectionChanged event to any listeners.
        /// Properties/methods modifying this ObservableCollection will raise
        /// a collection changed event through this virtual method.
        /// </summary>
        /// <remarks>
        /// When overriding this method, either call its base implementation
        /// to guard against reentrant collection changes.
        /// </remarks>
        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
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

        /// <summary> Check and assert for reentrant attempts to change this collection. </summary>
        /// <exception cref="InvalidOperationException"> raised when changing the collection
        /// while another collection change is still being notified to other listeners </exception>
        protected void CheckReentrancy()
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

        private void OnCollectionChanged(NotifyCollectionChangedAction action, object? item)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(action, item));
        }

        private void OnCollectionChanged(IList newItems, IList oldItems)
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newItems, oldItems));
        }

        #endregion
    }
}
