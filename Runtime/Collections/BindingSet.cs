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
    public class BindingSet<T> : HashSetBase<T>, ICollection<T>, ISet<T>, IReadOnlyCollection<T>, IReadOnlySet<T> /*, IBindingList, IRaiseItemChangedEvents*/
    {
        #region Constructors

        public BindingSet()
        {
        }

        public BindingSet(IEqualityComparer<T>? comparer) : base(comparer)
        {
        }

        public BindingSet(int capacity) : base(capacity)
        {
        }

        public BindingSet(IEnumerable<T> collection) : base(collection)
        {
        }

        public BindingSet(ISet<T> set) : base(set)
        {
        }

        public BindingSet(IEnumerable<T> collection, IEqualityComparer<T>? comparer) : base(collection, comparer)
        {
        }

        public BindingSet(int capacity, IEqualityComparer<T>? comparer) : base(capacity, comparer)
        {
        }

        #endregion


        #region Overrides Method

        protected override bool AddItem(T item)
        {
            return base.AddItem(item);
        }

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
