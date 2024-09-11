// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CiccioSoft.Collections
{
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class ListBase<T> : IList<T>, IList, IReadOnlyList<T>
    {
        protected List<T> _list;

        #region Constructors

        public ListBase()
        {
            _list = new List<T>();
        }

        public ListBase(IEnumerable<T> collection)
        {
            _list = new List<T>(collection);
        }

        public ListBase(int capacity)
        {
            _list = new List<T>(capacity);
        }

        #endregion

        #region Public Property

        public int Capacity
        {
            get => _list.Capacity;
            set => _list.Capacity = value;
        }

        #endregion

        #region IList<T>

        public T this[int index]
        {
            get => _list[index];
            set
            {
                if (((ICollection<T>)_list).IsReadOnly)
                {
                    ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
                }

                if ((uint)index >= (uint)_list.Count)
                {
                    ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
                }

                SetItem(index, value);
            }
        }

        public int IndexOf(T item) => _list.IndexOf(item);

        public void Insert(int index, T item)
        {
            if ((uint)index > (uint)_list.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
            }

            InsertItem(index, item);
        }

        public void RemoveAt(int index)
        {
            if ((uint)index >= (uint)_list.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
            }

            RemoveItem(index);
        }

        #endregion

        #region ICollection<T>

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            int index = _list.Count;
            InsertItem(index, item);
        }

        public void Clear()
        {
            ClearItems();
        }

        public bool Contains(T item) => _list.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => _list.CopyTo(array, arrayIndex);

        public bool Remove(T item)
        {
            int index = _list.IndexOf(item);
            if (index < 0) return false;
            RemoveItem(index);
            return true;
        }

        #endregion

        #region IList

        object? IList.this[int index]
        {
            get => _list[index];
            set
            {
                ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);

                T? item = default;

                try
                {
                    item = (T)value!;
                }
                catch (InvalidCastException)
                {
                    ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
                }

                this[index] = item;
            }
        }

        bool IList.IsFixedSize => ((IList)_list).IsFixedSize;

        int IList.Add(object? value)
        {
            ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);

            T? item = default;

            try
            {
                item = (T)value!;
            }
            catch (InvalidCastException)
            {
                ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
            }

            Add(item);

            return this.Count - 1;
        }

        bool IList.Contains(object? value) => ((IList)_list).Contains(value);

        int IList.IndexOf(object? value) => ((IList)_list).IndexOf(value);

        void IList.Insert(int index, object? value)
        {
            ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);

            T? item = default;

            try
            {
                item = (T)value!;
            }
            catch (InvalidCastException)
            {
                ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
            }

            Insert(index, item);
        }

        void IList.Remove(object? value)
        {
            if (IsCompatibleObject(value))
            {
                Remove((T)value!);
            }
        }

        #endregion

        #region ICollection

        bool ICollection.IsSynchronized => false;

        object ICollection.SyncRoot => ((ICollection)_list).SyncRoot;

        void ICollection.CopyTo(Array array, int index) => ((ICollection)_list).CopyTo(array, index);

        #endregion

        #region IReadOnlyList<T>

        T IReadOnlyList<T>.this[int index] => _list[index];

        #endregion

        #region IEnumerable

        public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_list).GetEnumerator();

        #endregion

        #region Virtual Method 

        protected virtual void ClearItems()
        {
            _list.Clear();
        }

        protected virtual void InsertItem(int index, T item)
        {
            _list.Insert(index, item);
        }

        protected virtual void RemoveItem(int index)
        {
            _list.RemoveAt(index);
        }

        protected virtual void SetItem(int index, T item)
        {
            _list[index] = item;
        }

        #endregion

        #region Private Method

        private static bool IsCompatibleObject(object? value)
        {
            // Non-null values are fine.  Only accept nulls if T is a class or Nullable<U>.
            // Note that default(T) is not equal to null for value types except when T is Nullable<U>.
            return (value is T) || (value == null && default(T) == null);
        }

        #endregion
    }
}
