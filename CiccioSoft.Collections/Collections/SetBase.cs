// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CiccioSoft.Collections
{
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class SetBase<T> : ISet<T>, ICollection<T>, IReadOnlySet<T>, IReadOnlyCollection<T>, ICollection
    {
        protected HashSet<T> _set;

        #region Constructors

        public SetBase()
            => _set = new HashSet<T>();

        public SetBase(IEqualityComparer<T>? comparer)
            => _set = new HashSet<T>(comparer);

#if NET6_0_OR_GREATER

        public SetBase(int capacity)
            => _set = new HashSet<T>(capacity);

#endif

        public SetBase(IEnumerable<T> collection)
            => _set = new HashSet<T>(collection);

        public SetBase(IEnumerable<T> collection, IEqualityComparer<T>? comparer)
            => _set = new HashSet<T>(collection, comparer);

#if NET6_0_OR_GREATER

        public SetBase(int capacity, IEqualityComparer<T>? comparer)
            => _set = new HashSet<T>(capacity, comparer);

#endif

        #endregion

        #region Public Property

        /// <summary>
        /// Gets the <see cref="IEqualityComparer"/> object that is used to determine equality for the values in the set.
        /// </summary>
        public IEqualityComparer<T> Comparer => _set.Comparer;

        #endregion

        #region Public Method

        public ReadOnlySet<T> AsReadOnly()
        {
            return new ReadOnlySet<T>(this);
        }

        #endregion

        #region Virtual Methods

        protected virtual bool AddItem(T item)
            => _set.Add(item);

        protected virtual void ClearItems()
            => _set.Clear();

        protected virtual void ExceptWithItems(IEnumerable<T> other)
            => _set.ExceptWith(other);

        protected virtual void IntersectWithItems(IEnumerable<T> other)
            => _set.IntersectWith(other);

        protected virtual bool RemoveItem(T item)
            => _set.Remove(item);

        protected virtual void SymmetricExceptWithItems(IEnumerable<T> other)
            => _set.SymmetricExceptWith(other);

        protected virtual void UnionWithItems(IEnumerable<T> other)
            => _set.UnionWith(other);

        #endregion

        #region ISet<T>

        /// <inheritdoc/>
        public bool Add(T item) => AddItem(item);

        /// <inheritdoc/>
        public void ExceptWith(IEnumerable<T> other)
        {
            // Special case if other is this; a set minus itself is the empty set.
            if (other == this)
            {
                ClearItems();
                return;
            }
            ExceptWithItems(other);
        }

        /// <inheritdoc/>
        public void IntersectWith(IEnumerable<T> other) => IntersectWithItems(other);

        /// <inheritdoc/>
        public bool IsProperSubsetOf(IEnumerable<T> other) => _set.IsProperSubsetOf(other);

        /// <inheritdoc/>
        public bool IsProperSupersetOf(IEnumerable<T> other) => _set.IsProperSupersetOf(other);

        /// <inheritdoc/>
        public bool IsSubsetOf(IEnumerable<T> other) => _set.IsSubsetOf(other);

        /// <inheritdoc/>
        public bool IsSupersetOf(IEnumerable<T> other) => _set.IsSupersetOf(other);

        /// <inheritdoc/>
        public bool Overlaps(IEnumerable<T> other) => _set.Overlaps(other);

        /// <inheritdoc/>
        public bool SetEquals(IEnumerable<T> other) => _set.SetEquals(other);

        /// <inheritdoc/>
        public void SymmetricExceptWith(IEnumerable<T> other) => SymmetricExceptWithItems(other);

        /// <inheritdoc/>
        public void UnionWith(IEnumerable<T> other) => UnionWithItems(other);

        #endregion

        #region ICollection<T>

        /// <inheritdoc/>
        public int Count => _set.Count;

        /// <inheritdoc/>
        bool ICollection<T>.IsReadOnly => false;

        /// <inheritdoc/>
        void ICollection<T>.Add(T item) => Add(item);

        /// <inheritdoc/>
        public void Clear() => ClearItems();

        /// <inheritdoc/>
        public bool Contains(T item) => _set.Contains(item);

        /// <inheritdoc/>
        public void CopyTo(T[] array, int arrayIndex) => _set.CopyTo(array, arrayIndex);

        /// <inheritdoc/>
        public bool Remove(T item) => RemoveItem(item);

        #endregion

        #region ICollection

        /// <inheritdoc/>
        void ICollection.CopyTo(Array array, int index) => CollectionHelpers.CopyTo(_set, array, index);

        /// <inheritdoc/>
        bool ICollection.IsSynchronized => false;

        /// <inheritdoc/>
        object ICollection.SyncRoot => _set is ICollection c ? c.SyncRoot : this;

        #endregion

        #region IEnumerable

        /// <inheritdoc/>
        public IEnumerator<T> GetEnumerator() => _set.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => ((IEnumerable<T>)_set).GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_set).GetEnumerator();

        #endregion
    }
}
