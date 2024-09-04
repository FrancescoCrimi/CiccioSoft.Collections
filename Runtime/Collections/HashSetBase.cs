// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CiccioSoft.Collections;

[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class HashSetBase<T> : ICollection<T>, ISet<T>, IReadOnlyCollection<T>, IReadOnlySet<T>
{
    protected ISet<T> _set;

    #region Constructors

    public HashSetBase()
        => _set = new HashSet<T>();

    public HashSetBase(IEqualityComparer<T>? comparer)
        => _set = new HashSet<T>(comparer);

    public HashSetBase(int capacity)
        => _set = new HashSet<T>(capacity);

    public HashSetBase(IEnumerable<T> collection)
        => _set = new HashSet<T>(collection);

    public HashSetBase(IEnumerable<T> collection, IEqualityComparer<T>? comparer)
        => _set = new HashSet<T>(collection, comparer);

    public HashSetBase(int capacity, IEqualityComparer<T>? comparer)
        => _set = new HashSet<T>(capacity, comparer);

    public HashSetBase(ISet<T> set)
        => _set = set;

    #endregion


    #region ISet

    public int Count
        => _set.Count;

    public bool IsReadOnly
        => _set.IsReadOnly;

    public bool Add(T item)
        => AddItem(item);

    public void Clear()
        => ClearItems();

    public bool Contains(T item)
        => _set.Contains(item);

    public void CopyTo(T[] array, int arrayIndex)
        => _set.CopyTo(array, arrayIndex);

    public void ExceptWith(IEnumerable<T> other)
        => ExceptWithItems(other);

    public IEnumerator<T> GetEnumerator()
        => _set.GetEnumerator();

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

    public bool Remove(T item)
        => RemoveItem(item);

    public bool SetEquals(IEnumerable<T> other)
        => _set.SetEquals(other);

    public void SymmetricExceptWith(IEnumerable<T> other)
        => SymmetricExceptWithItems(other);

    public void UnionWith(IEnumerable<T> other)
        => UnionWithItems(other);

    void ICollection<T>.Add(T item)
        => Add(item);

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
