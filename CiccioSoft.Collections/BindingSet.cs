// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Francesco Crimi francrim@gmail.com

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace CiccioSoft.Collections.Generic
{
    [Serializable]
    [DebuggerTypeProxy(typeof(CollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class BindingSet<T> : ISet<T>, IBindingList, IRaiseItemChangedEvents, IReadOnlyCollection<T>
    {
        private HashSet<T> items;
        private List<T> genericList;

        private bool raiseItemChangedEvents;
        [NonSerialized]
        private int _lastChangeIndex = -1;
        [NonSerialized]
        private PropertyDescriptorCollection _itemTypeProperties;


        #region Constructors

        public BindingSet()
        {
            items = new HashSet<T>();
            genericList = new List<T>(items);
            Initialize();
        }
        public BindingSet(IEnumerable<T> collection)
        {
            items = new HashSet<T>(collection);
            genericList = new List<T>(items);
            Initialize();
        }
        public BindingSet(IEqualityComparer<T> comparer)
        {
            items = new HashSet<T>(comparer);
            genericList = new List<T>(items);
            Initialize();
        }
        public BindingSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
        {
            items = new HashSet<T>(collection, comparer);
            genericList = new List<T>(items);
            Initialize();
        }

        private void Initialize()
        {
            if (typeof(INotifyPropertyChanged).IsAssignableFrom(typeof(T)))
            {
                raiseItemChangedEvents = true;
                foreach (T item in items)
                {
                    HookPropertyChanged(item);
                }
            }
        }

        #endregion


        #region ISet

        public int Count => items.Count;

        public bool IsReadOnly => ((ICollection<T>)items).IsReadOnly;

        public bool Add(T item)
        {
            if (items.Contains(item)) return false;

            items.Add(item);
            genericList = new List<T>(items);
            int index = genericList.IndexOf(item);
            if (raiseItemChangedEvents)
                HookPropertyChanged(item);

            OnListChanged(new ListChangedEventArgs(ListChangedType.ItemAdded, index));
            return true;
        }

        public void Clear()
        {
            if (items.Count == 0) return;

            if (raiseItemChangedEvents)
            {
                foreach (T item in items)
                {
                    UnhookPropertyChanged(item);
                }
            }
            items.Clear();
            genericList.Clear();

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        public bool Contains(T item) => items.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);

        public void ExceptWith(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.ExceptWith(other);
            if (copy.Count == items.Count) return;
            var removed = items.Where(i => !copy.Contains(i)).ToList();

            items = copy;
            genericList = new List<T>(items);

            if (raiseItemChangedEvents)
            {
                foreach (T item in removed)
                {
                    UnhookPropertyChanged(item);
                }
            }

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

        public void IntersectWith(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.IntersectWith(other);
            if (copy.Count == items.Count) return;
            var removed = items.Where(i => !copy.Contains(i)).ToList();

            items = copy;
            genericList = new List<T>(items);

            if (raiseItemChangedEvents)
            {
                foreach (T item in removed)
                {
                    UnhookPropertyChanged(item);
                }
            }

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        public bool IsProperSubsetOf(IEnumerable<T> other) => items.IsProperSubsetOf(other);

        public bool IsProperSupersetOf(IEnumerable<T> other) => items.IsProperSupersetOf(other);

        public bool IsSubsetOf(IEnumerable<T> other) => items.IsSubsetOf(other);

        public bool IsSupersetOf(IEnumerable<T> other) => items.IsSupersetOf(other);

        public bool Overlaps(IEnumerable<T> other) => items.Overlaps(other);

        public bool Remove(T item)
        {
            if (!items.Contains(item)) return false;

            if (raiseItemChangedEvents)
                UnhookPropertyChanged(item);
            int index = genericList.IndexOf(item);

            items.Remove(item);
            genericList = new List<T>(items);

            OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
            return true;
        }

        public bool SetEquals(IEnumerable<T> other) => items.SetEquals(other);

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.SymmetricExceptWith(other);
            var removed = items.Where(i => !copy.Contains(i)).ToList();
            var added = copy.Where(i => !items.Contains(i)).ToList();
            if (removed.Count == 0 && added.Count == 0) return;

            items = copy;
            genericList = new List<T>(items);
            if (raiseItemChangedEvents)
            {
                foreach (T item in added)
                {
                    HookPropertyChanged(item);
                }
                foreach (T item in removed)
                {
                    UnhookPropertyChanged(item);
                }
            }
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        public void UnionWith(IEnumerable<T> other)
        {
            var copy = new HashSet<T>(items, items.Comparer);
            copy.UnionWith(other);
            if (copy.Count == items.Count) return;
            var added = copy.Where(i => !items.Contains(i)).ToList();

            items = copy;
            genericList = new List<T>(items);
            if (raiseItemChangedEvents)
            {
                foreach (T item in added)
                {
                    HookPropertyChanged(item);
                }
            }

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        void ICollection<T>.Add(T item) => Add(item);

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();

        #endregion


        #region IList

        int ICollection.Count => items.Count;
        bool ICollection.IsSynchronized => false;
        object ICollection.SyncRoot => this;
        bool IList.IsFixedSize => false;
        bool IList.IsReadOnly => true;
        object IList.this[int index] { get => genericList[index]; set => throw new NotSupportedException(); }
        void ICollection.CopyTo(Array array, int index) => ((IList)genericList).CopyTo(array, index);
        int IList.Add(object value) => throw new NotSupportedException();
        void IList.Clear() => throw new NotSupportedException();
        bool IList.Contains(object value) => ((IList)genericList).Contains(value);
        int IList.IndexOf(object value) => ((IList)genericList).IndexOf((T)value);
        void IList.Insert(int index, object value) => throw new NotSupportedException();
        void IList.Remove(object value) => throw new NotSupportedException();
        void IList.RemoveAt(int index) => throw new NotSupportedException();

        #endregion


        #region IBindingList

        [field: NonSerialized]
        public event ListChangedEventHandler ListChanged;

        private void OnListChanged(ListChangedEventArgs e) => ListChanged?.Invoke(this, e);

        private void HookPropertyChanged(T item)
        {
            if (item is INotifyPropertyChanged inpc)
                inpc.PropertyChanged += Child_PropertyChanged;
        }

        private void UnhookPropertyChanged(T item)
        {
            if (item is INotifyPropertyChanged inpc)
                inpc.PropertyChanged -= Child_PropertyChanged;
        }

        private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender == null || e == null || string.IsNullOrEmpty(e.PropertyName))
            {
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
            else
            {
                T item;
                try
                {
                    item = (T)sender;
                }
                catch (InvalidCastException)
                {
                    OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
                    return;
                }
                int pos = _lastChangeIndex;
                if (pos < 0 || pos >= Count || !this.ToList()[pos].Equals(item))
                {
                    pos = this.ToList().IndexOf(item);
                    _lastChangeIndex = pos;
                }

                if (pos == -1)
                {
                    UnhookPropertyChanged(item);
                    OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
                }
                else
                {
                    if (null == _itemTypeProperties)
                    {
                        _itemTypeProperties = TypeDescriptor.GetProperties(typeof(T));
                        Debug.Assert(_itemTypeProperties != null);
                    }
                    PropertyDescriptor pd = _itemTypeProperties.Find(e.PropertyName, true);
                    ListChangedEventArgs args = new ListChangedEventArgs(ListChangedType.ItemChanged, pos, pd);
                    OnListChanged(args);
                }
            }
        }

        object IBindingList.AddNew() => throw new NotSupportedException();
        bool IBindingList.AllowNew => false;
        bool IBindingList.AllowEdit => true;
        bool IBindingList.AllowRemove => true;
        bool IBindingList.SupportsChangeNotification => true;
        bool IBindingList.SupportsSearching => false;
        bool IBindingList.SupportsSorting => false;
        bool IBindingList.IsSorted => false;
        PropertyDescriptor IBindingList.SortProperty => null;
        ListSortDirection IBindingList.SortDirection => ListSortDirection.Ascending;
        void IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction) => throw new NotSupportedException();
        void IBindingList.RemoveSort() => throw new NotSupportedException();
        int IBindingList.Find(PropertyDescriptor prop, object key) => throw new NotSupportedException();
        void IBindingList.AddIndex(PropertyDescriptor prop) { }
        void IBindingList.RemoveIndex(PropertyDescriptor prop) { }

        #endregion


        #region IRaiseItemChangedEvents

        bool IRaiseItemChangedEvents.RaisesItemChangedEvents => raiseItemChangedEvents;

        #endregion   
    }
}
