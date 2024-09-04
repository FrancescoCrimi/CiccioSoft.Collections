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
    public class CollectionBase<T> : IList<T>, IList, IReadOnlyList<T>
    {
        private readonly IList<T> items; // Do not rename (binary serialization)

        #region Constructors

        public CollectionBase()
        {
            items = new List<T>();
        }

        public CollectionBase(IList<T> list)
        {
            if (list == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.list);
            }

            if (list is T[])
            {
                items = new List<T>(list);
            }
            else
            {
                items = list;
            }
        }

        public CollectionBase(int capacity)
        {
            items = new List<T>(capacity);
        }

        public CollectionBase(IEnumerable<T> enumerable)
        {
            items = new List<T>(enumerable);
        }

        #endregion

        #region IEnumerable methods

        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();

        #endregion

        #region ICollection

        bool ICollection.IsSynchronized => false;

        object ICollection.SyncRoot => items is ICollection coll ? coll.SyncRoot : this;

        void ICollection.CopyTo(Array array, int index)
        {
            if (array == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
            }

            if (array.Rank != 1)
            {
                ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
            }

            if (array.GetLowerBound(0) != 0)
            {
                ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
            }

            if (index < 0)
            {
                ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
            }

            if (array.Length - index < Count)
            {
                ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
            }

            if (array is T[] tArray)
            {
                items.CopyTo(tArray, index);
            }
            else
            {
                //
                // Catch the obvious case assignment will fail.
                // We can't find all possible problems by doing the check though.
                // For example, if the element type of the Array is derived from T,
                // we can't figure out if we can successfully copy the element beforehand.
                //
                Type targetType = array.GetType().GetElementType()!;
                Type sourceType = typeof(T);
                if (!(targetType.IsAssignableFrom(sourceType) || sourceType.IsAssignableFrom(targetType)))
                {
                    ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
                }

                //
                // We can't cast array of value type to object[], so we don't support
                // widening of primitive types here.
                //
                object?[]? objects = array as object[];
                if (objects == null)
                {
                    ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
                }

                int count = items.Count;
                try
                {
                    for (int i = 0; i < count; i++)
                    {
                        objects[index++] = items[i];
                    }
                }
                catch (ArrayTypeMismatchException)
                {
                    ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
                }
            }
        }

        #endregion

        #region ICollection<T>

        public void Add(T item)
        {
            if (items.IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }

            int index = items.Count;
            InsertItem(index, item);
        }

        public bool Contains(T item) => items.Contains(item);

        public void CopyTo(T[] array, int index) => items.CopyTo(array, index);

        public bool Remove(T item)
        {
            if (items.IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }

            int index = items.IndexOf(item);
            if (index < 0) return false;
            RemoveItem(index);
            return true;
        }

        #endregion

        #region ICollection<T> ICollection Shared

        public int Count => items.Count;

        #endregion

        #region IList

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

        bool IList.IsFixedSize
        {
            get
            {
                // There is no IList<T>.IsFixedSize, so we must assume that only
                // readonly collections are fixed size, if our internal item
                // collection does not implement IList.  Note that Array implements
                // IList, and therefore T[] and U[] will be fixed-size.
                if (items is IList list)
                {
                    return list.IsFixedSize;
                }
                return items.IsReadOnly;
            }
        }

        int IList.Add(object? value)
        {
            if (items.IsReadOnly)
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

        bool IList.Contains(object? value)
        {
            if (IsCompatibleObject(value))
            {
                return Contains((T)value!);
            }
            return false;
        }

        int IList.IndexOf(object? value)
        {
            if (IsCompatibleObject(value))
            {
                return IndexOf((T)value!);
            }
            return -1;
        }

        void IList.Insert(int index, object? value)
        {
            if (items.IsReadOnly)
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

        void IList.Remove(object? value)
        {
            if (items.IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }

            if (IsCompatibleObject(value))
            {
                Remove((T)value!);
            }
        }

        #endregion

        #region IList ICollection<T> Shared

        public bool IsReadOnly => items.IsReadOnly;

        public void Clear()
        {
            if (items.IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }

            ClearItems();
        }

        #endregion

        #region IList<T>

        public T this[int index]
        {
            get => items[index];
            set
            {
                if (items.IsReadOnly)
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

        public int IndexOf(T item) => items.IndexOf(item);

        public void Insert(int index, T item)
        {
            if (items.IsReadOnly)
            {
                ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            }

            if ((uint)index > (uint)items.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
            }

            InsertItem(index, item);
        }

        #endregion

        #region IList<T> IList Shared

        public void RemoveAt(int index)
        {
            if (items.IsReadOnly)
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

        public ReadOnlyCollection<T> AsReadOnly()
            => new ReadOnlyCollection<T>(this);

        protected IList<T> Items => items;
    }
}
