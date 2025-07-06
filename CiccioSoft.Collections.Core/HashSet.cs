// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CiccioSoft.Collections
{
    /// <summary>
    /// Thin wrapper around <see cref="System.Collections.Generic.HashSet{T}"/> that exposes
    /// only <see cref="ISet{T}"/> and <see cref="IReadOnlySet{T}"/> interfaces.
    /// Designed as a base class for custom generic set collections, providing controlled
    /// access to the underlying set implementation.
    /// <para>
    /// This class is inspired by <see cref="System.Collections.ObjectModel.Collection{T}"/>
    /// from the .NET runtime and by the ObservableHashSet implementation from
    /// <see href="https://github.com/dotnet/efcore/blob/main/src/EFCore/ChangeTracking/ObservableHashSet.cs">
    /// Entity Framework Core</see>.
    /// </para>
    /// </summary>
    /// <typeparam name="T">The type of elements in the set.</typeparam>
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class HashSet<T> : ISet<T>, IReadOnlySet<T>, ICollection
    {
        protected System.Collections.Generic.HashSet<T> items;

        #region Constructors

        public HashSet()
            => items = new System.Collections.Generic.HashSet<T>();

        public HashSet(IEqualityComparer<T>? comparer)
            => items = new System.Collections.Generic.HashSet<T>(comparer);

#if NETCOREAPP2_1_OR_GREATER || NET472_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        public HashSet(int capacity)
            => items = new System.Collections.Generic.HashSet<T>(capacity);
#endif

        public HashSet(IEnumerable<T> collection)
            => items = new System.Collections.Generic.HashSet<T>(collection);

        public HashSet(IEnumerable<T> collection, IEqualityComparer<T>? comparer)
            => items = new System.Collections.Generic.HashSet<T>(collection, comparer);

#if NETCOREAPP2_1_OR_GREATER || NET472_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        public HashSet(int capacity, IEqualityComparer<T>? comparer)
            => items = new System.Collections.Generic.HashSet<T>(capacity, comparer);
#endif

        #endregion


        #region Public Property

        /// <summary>
        /// Gets the <see cref="IEqualityComparer"/> object that is used to determine equality for the values in the set.
        /// </summary>
        public IEqualityComparer<T> Comparer => items.Comparer;

        #endregion


        #region Public Method

        public ReadOnlySet<T> AsReadOnly()
        {
            return new ReadOnlySet<T>(this);
        }


#if NETCOREAPP2_1_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        /// <summary>
        /// Ensures that this hash set can hold the specified number of elements without growing.
        /// </summary>
        /// <param name="capacity">The minimum capacity to ensure.</param>
        /// <returns>The new capacity of this instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="capacity"/> is less than zero.</exception>
        public int EnsureCapacity(int capacity)
            => items.EnsureCapacity(capacity);
#endif

        #endregion


        #region Protected Virtual Methods

        protected virtual bool AddItem(T item)
            => items.Add(item);

        protected virtual void ClearItems()
            => items.Clear();

        protected virtual void ExceptWithItems(IEnumerable<T> other)
            => items.ExceptWith(other);

        protected virtual void IntersectWithItems(IEnumerable<T> other)
            => items.IntersectWith(other);

        protected virtual bool RemoveItem(T item)
            => items.Remove(item);

        protected virtual void SymmetricExceptWithItems(IEnumerable<T> other)
            => items.SymmetricExceptWith(other);

        protected virtual void UnionWithItems(IEnumerable<T> other)
            => items.UnionWith(other);

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
        public bool IsProperSubsetOf(IEnumerable<T> other) => items.IsProperSubsetOf(other);

        /// <inheritdoc/>
        public bool IsProperSupersetOf(IEnumerable<T> other) => items.IsProperSupersetOf(other);

        /// <inheritdoc/>
        public bool IsSubsetOf(IEnumerable<T> other) => items.IsSubsetOf(other);

        /// <inheritdoc/>
        public bool IsSupersetOf(IEnumerable<T> other) => items.IsSupersetOf(other);

        /// <inheritdoc/>
        public bool Overlaps(IEnumerable<T> other) => items.Overlaps(other);

        /// <inheritdoc/>
        public bool SetEquals(IEnumerable<T> other) => items.SetEquals(other);

        /// <inheritdoc/>
        public void SymmetricExceptWith(IEnumerable<T> other) => SymmetricExceptWithItems(other);

        /// <inheritdoc/>
        public void UnionWith(IEnumerable<T> other) => UnionWithItems(other);

        #endregion


        #region ICollection<T>

        /// <inheritdoc/>
        public int Count => items.Count;

        /// <inheritdoc/>
        bool ICollection<T>.IsReadOnly => false;

        /// <inheritdoc/>
        void ICollection<T>.Add(T item) => Add(item);

        /// <inheritdoc/>
        public void Clear() => ClearItems();

        /// <inheritdoc/>
        public bool Contains(T item) => items.Contains(item);

        /// <inheritdoc/>
        public void CopyTo(T[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);

        /// <inheritdoc/>
        public bool Remove(T item) => RemoveItem(item);

        #endregion


        #region ICollection

        /// <inheritdoc/>
        void ICollection.CopyTo(Array array, int index) => CollectionHelpers.CopyTo(items, array, index);

        /// <inheritdoc/>
        bool ICollection.IsSynchronized => false;

        /// <inheritdoc/>
        object ICollection.SyncRoot => items is ICollection c ? c.SyncRoot : this;

        #endregion


        #region IEnumerable

        /// <inheritdoc/>
        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => ((IEnumerable<T>)items).GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();

        #endregion
    }
}
