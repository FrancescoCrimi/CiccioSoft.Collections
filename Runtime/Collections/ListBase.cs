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
    public class ListBase<T> : IList<T>, IList, IReadOnlyList<T>
    {
        protected List<T> items;

        #region Constructors

        public ListBase()
        {
            items = new List<T>();
        }

        public ListBase(IEnumerable<T> collection)
        {
            items = new List<T>(collection);
        }

        public ListBase(int capacity)
        {
            items = new List<T>(capacity);
        }

        #endregion


        #region Interface Implementation

        public T this[int index]
        {
            get => items[index];
            set
            {
                if (((ICollection<T>)items).IsReadOnly)
                {
                    ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
                }

                if ((uint)index >= (uint)items.Count)
                {
                    ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
                }

                SetItem(index, value);
            }
        }

        object? IList.this[int index]
        {
            get => items[index];
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

        T IReadOnlyList<T>.this[int index] => items[index];

        public int Count => items.Count;

        public bool IsReadOnly => ((ICollection<T>)items).IsReadOnly;

        bool IList.IsFixedSize => ((IList)items).IsFixedSize;

        bool ICollection.IsSynchronized => false;

        object ICollection.SyncRoot => ((ICollection)items).SyncRoot;

        public void Add(T item)
        {
            if (((ICollection<T>)items).IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }

            int index = items.Count;
            InsertItem(index, item);
        }

        int IList.Add(object? value)
        {
            if (((ICollection<T>)items).IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }
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

        public void Clear()
        {
            if (((ICollection<T>)items).IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }

            ClearItems();
        }

        public bool Contains(T item) => items.Contains(item);

        bool IList.Contains(object? value) => ((IList)items).Contains(value);

        public void CopyTo(T[] array, int arrayIndex)  => items.CopyTo(array, arrayIndex);

        void ICollection.CopyTo(Array array, int index) => ((ICollection)items).CopyTo(array, index);

        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();

        public int IndexOf(T item) => items.IndexOf(item);

        int IList.IndexOf(object? value) => ((IList)items).IndexOf(value);

        public void Insert(int index, T item)
        {
            if (((ICollection<T>)items).IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }

            if ((uint)index > (uint)items.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
            }

            InsertItem(index, item);
        }

        void IList.Insert(int index, object? value)
        {
            if (((ICollection<T>)items).IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }
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

        public bool Remove(T item)
        {
            if (((ICollection<T>)items).IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }

            int index = items.IndexOf(item);
            if (index < 0) return false;
            RemoveItem(index);
            return true;
        }

        void IList.Remove(object? value)
        {
            if (((ICollection<T>)items).IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }

            if (IsCompatibleObject(value))
            {
                Remove((T)value!);
            }
        }

        public void RemoveAt(int index)
        {
            if (((ICollection<T>)items).IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }

            if ((uint)index >= (uint)items.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
            }

            RemoveItem(index);
        }

        #endregion


        #region Public Property

        public int Capacity
        {
            get => items.Capacity;
            set => items.Capacity = value;
        }

        #endregion


        #region Virtual Method 

        protected virtual void ClearItems()
        {
            items.Clear();
        }

        protected virtual void InsertItem(int index, T item)
        {
            items.Insert(index, item);
        }

        protected virtual void RemoveItem(int index)
        {
            items.RemoveAt(index);
        }

        protected virtual void SetItem(int index, T item)
        {
            items[index] = item;
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
