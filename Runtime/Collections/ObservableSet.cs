// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CiccioSoft.Collections
{
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    [Serializable]
    public class ObservableSet<T> : HashSetBase<T>, ICollection<T>, ISet<T>, IReadOnlyCollection<T>, IReadOnlySet<T>
    {
        #region Constructors

        public ObservableSet()
        {
        }

        public ObservableSet(IEqualityComparer<T>? comparer) : base(comparer)
        {
        }

        public ObservableSet(int capacity) : base(capacity)
        {
        }

        public ObservableSet(IEnumerable<T> collection) : base(collection)
        {
        }

        public ObservableSet(ISet<T> set) : base(set)
        {
        }

        public ObservableSet(IEnumerable<T> collection, IEqualityComparer<T>? comparer) : base(collection, comparer)
        {
        }

        public ObservableSet(int capacity, IEqualityComparer<T>? comparer) : base(capacity, comparer)
        {
        }

        #endregion


        #region Overrides Method

        protected override bool AddItem(T item)
        {
            if (_set.Contains(item))
            {
                return false;
            }

            //OnCountPropertyChanging();

            _set.Add(item);

            //OnCollectionChanged(NotifyCollectionChangedAction.Add, item);

            //OnCountPropertyChanged();

            return true;
        }

        protected override void ClearItems()
        {
            if (_set.Count == 0)
            {
                return;
            }

            //OnCountPropertyChanging();

            var removed = this.ToList();

            _set.Clear();

            //OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

            //OnCountPropertyChanged();
        }

        protected override void ExceptWithItems(IEnumerable<T> other)
        {
            //var copy = new HashSet<T>(_set, _set.Comparer);
            var copy = new HashSet<T>(_set);

            copy.ExceptWith(other);

            if (copy.Count == _set.Count)
            {
                return;
            }

            var removed = _set.Where(i => !copy.Contains(i)).ToList();

            //OnCountPropertyChanging();

            _set = copy;

            //OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

            //OnCountPropertyChanged();
        }

        protected override void IntersectWithItems(IEnumerable<T> other)
        {
            //var copy = new HashSet<T>(_set, _set.Comparer);
            var copy = new HashSet<T>(_set);

            copy.IntersectWith(other);

            if (copy.Count == _set.Count)
            {
                return;
            }

            var removed = _set.Where(i => !copy.Contains(i)).ToList();

            //OnCountPropertyChanging();

            _set = copy;

            //OnCollectionChanged(ObservableHashSetSingletons.NoItems, removed);

            //OnCountPropertyChanged();
        }

        protected override bool RemoveItem(T item)
        {
            if (!_set.Contains(item))
            {
                return false;
            }

            //OnCountPropertyChanging();

            _set.Remove(item);

            //OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);

            //OnCountPropertyChanged();

            return true;
        }

        protected override void SymmetricExceptWithItems(IEnumerable<T> other)
        {
            //var copy = new HashSet<T>(_set, _set.Comparer);
            var copy = new HashSet<T>(_set);

            copy.SymmetricExceptWith(other);

            var removed = _set.Where(i => !copy.Contains(i)).ToList();
            var added = copy.Where(i => !_set.Contains(i)).ToList();

            if (removed.Count == 0
                && added.Count == 0)
            {
                return;
            }

            //OnCountPropertyChanging();

            _set = copy;

            //OnCollectionChanged(added, removed);

            //OnCountPropertyChanged();
        }

        protected override void UnionWithItems(IEnumerable<T> other)
        {
            //var copy = new HashSet<T>(_set, _set.Comparer);
            var copy = new HashSet<T>(_set);

            copy.UnionWith(other);

            if (copy.Count == _set.Count)
            {
                return;
            }

            var added = copy.Where(i => !_set.Contains(i)).ToList();

            //OnCountPropertyChanging();

            _set = copy;

            //OnCollectionChanged(added, ObservableHashSetSingletons.NoItems);

            //OnCountPropertyChanged();
        }

        #endregion
    }
}
