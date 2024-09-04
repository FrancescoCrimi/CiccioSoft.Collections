// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CiccioSoft.Collections
{
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    [Serializable]
    public class CiccioSet<T> : HashSetBase<T>, ICollection<T>, ISet<T>, IReadOnlyCollection<T>, IReadOnlySet<T>
    {
        #region Constructors

        public CiccioSet()
        {
        }

        public CiccioSet(IEqualityComparer<T>? comparer) : base(comparer)
        {
        }

        public CiccioSet(int capacity) : base(capacity)
        {
        }

        public CiccioSet(IEnumerable<T> collection) : base(collection)
        {
        }

        public CiccioSet(ISet<T> set) : base(set)
        {
        }

        public CiccioSet(IEnumerable<T> collection, IEqualityComparer<T>? comparer) : base(collection, comparer)
        {
        }

        public CiccioSet(int capacity, IEqualityComparer<T>? comparer) : base(capacity, comparer)
        {
        }

        #endregion


        #region Overrides Method

        protected override void ClearItems()
        {
            base.ClearItems();
        }

        protected override void ExceptWithItems(IEnumerable<T> other)
        {
            base.ExceptWithItems(other);
        }

        protected override void IntersectWithItems(IEnumerable<T> other)
        {
            base.IntersectWithItems(other);
        }

        protected override bool RemoveItem(T item)
        {
            return base.RemoveItem(item);
        }

        protected override void SymmetricExceptWithItems(IEnumerable<T> other)
        {
            base.SymmetricExceptWithItems(other);
        }

        protected override void UnionWithItems(IEnumerable<T> other)
        {
            base.UnionWithItems(other);
        }

        #endregion
    }
}
