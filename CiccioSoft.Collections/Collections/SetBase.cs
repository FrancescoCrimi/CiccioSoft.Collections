// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CiccioSoft.Collections
{
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    [Serializable]
    public class SetBase<T> : ICollection<T>, ISet<T>, IReadOnlyCollection<T>, IReadOnlySet<T>
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

        /// <summary>Gets the <see cref="IEqualityComparer"/> object that is used to determine equality for the values in the set.</summary>
        public IEqualityComparer<T> Comparer => _set.Comparer;

        #endregion

        #region ISet<T>

        public bool Add(T item)
            => AddItem(item);

        public void ExceptWith(IEnumerable<T> other)
            => ExceptWithItems(other);

        public void IntersectWith(IEnumerable<T> other)
            => IntersectWithItems(other);

        public bool IsProperSubsetOf(IEnumerable<T> other)
            => _set.IsProperSubsetOf(other);

        public bool IsProperSupersetOf(IEnumerable<T> other)
            => _set.IsProperSupersetOf(other);

        public bool IsSubsetOf(IEnumerable<T> other)
            => _set.IsSubsetOf(other);

        public bool IsSupersetOf(IEnumerable<T> other)
            => _set.IsSupersetOf(other);

        public bool Overlaps(IEnumerable<T> other)
            => _set.Overlaps(other);

        public bool SetEquals(IEnumerable<T> other)
            => _set.SetEquals(other);

        public void SymmetricExceptWith(IEnumerable<T> other)
            => SymmetricExceptWithItems(other);

        public void UnionWith(IEnumerable<T> other)
            => UnionWithItems(other);

        #endregion

        #region ICollection<T>

        public int Count => _set.Count;

        bool ICollection<T>.IsReadOnly => false;

        void ICollection<T>.Add(T item)
            => Add(item);

        public void Clear()
            => ClearItems();

        public bool Contains(T item)
            => _set.Contains(item);

        public void CopyTo(T[] array, int arrayIndex)
            => _set.CopyTo(array, arrayIndex);

        public bool Remove(T item)
            => RemoveItem(item);

        #endregion

        #region IEnumerable

        public IEnumerator<T> GetEnumerator()
            => _set.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

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
    }
}
