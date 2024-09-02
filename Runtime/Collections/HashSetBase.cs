using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CiccioSoft.Collections.Collections;

public class HashSetBase<T> : ICollection<T>, ISet<T>, IReadOnlyCollection<T>, IReadOnlySet<T>
{
    private ISet<T> _set;

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

    public int Count
        => _set.Count;

    public bool IsReadOnly
        => _set.IsReadOnly;

    public bool Add(T item)
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

    public void Clear()
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

    public bool Contains(T item)
        => _set.Contains(item);

    public void CopyTo(T[] array, int arrayIndex)
        => _set.CopyTo(array, arrayIndex);

    public void ExceptWith(IEnumerable<T> other)
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

    public IEnumerator<T> GetEnumerator()
        => _set.GetEnumerator();

    public void IntersectWith(IEnumerable<T> other)
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

    public bool SetEquals(IEnumerable<T> other)
        => _set.SetEquals(other);

    public void SymmetricExceptWith(IEnumerable<T> other)
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

    public void UnionWith(IEnumerable<T> other)
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

    void ICollection<T>.Add(T item)
        => Add(item);

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}
