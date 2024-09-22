// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CiccioSoft.Collections
{
    /// <summary>
    /// Represents a strongly typed list of objects that can be accessed by index.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class ListBase<T> : IList<T>, IList, IReadOnlyList<T>
    {
        protected List<T> _list;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref = "ListBase{T}" /> class that is empty and has the default initial capacity.
        /// </summary>
        public ListBase()
        {
            _list = new List<T>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ListBase{T}" /> class that contains elements copied from the specified collection and has sufficient capacity to accommodate the number of elements copied.
        /// </summary>
        /// <param name = "collection" > The collection whose elements are copied to the new list.</param>
        /// <exception cref = "ArgumentNullException" >
        /// <paramref name="collection" /> is <see langword = "null" />
        /// </exception>
        public ListBase(IEnumerable<T> collection)
        {
            _list = new List<T>(collection);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ListBase{T}" /> class that is empty and has the specified initial capacity.
        /// </summary>
        /// <param name = "capacity" > The number of elements that the new list can initially store.</param>
        /// <exception cref = "ArgumentOutOfRangeException" >
        /// <paramref name = "capacity" /> is less than 0.
        /// </exception>
        public ListBase(int capacity)
        {
            _list = new List<T>(capacity);
        }

        #endregion

        #region Public Property

        /// <summary>
        /// Gets or sets the total number of elements the internal data structure can hold without resizing.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <see cref="ListBase{T}.Capacity" /> is set to a value that is less than <see cref="ListBase{T}.Count" />.
        /// </exception>
        /// <exception cref="OutOfMemoryException">
        /// There is not enough memory available on the system.
        /// </exception>
        /// <returns>
        /// The number of elements that the <see cref="ListBase{T}" /> can contain before resizing is required.
        /// </returns>
        public int Capacity
        {
            get => _list.Capacity;
            set => _list.Capacity = value;
        }

        #endregion

        #region Public Method

        /// <summary>
        /// Returns a read-only <see cref="ReadOnlyCollection{T}" /> wrapper for the current collection.
        /// </summary>
        /// <returns>
        /// An object that acts as a read-only wrapper around the current <see cref="ListBase{T}" />.
        /// </returns>
        public ReadOnlyCollection<T> AsReadOnly()
        {
            return new ReadOnlyCollection<T>(this);
        }

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

        #region IList<T>

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public int IndexOf(T item) => _list.IndexOf(item);

        /// <inheritdoc/>
        public void Insert(int index, T item)
        {
            if ((uint)index > (uint)_list.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
            }

            InsertItem(index, item);
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public int Count => _list.Count;

        /// <inheritdoc/>
        public bool IsReadOnly => false;

        /// <inheritdoc/>
        public void Add(T item)
        {
            int index = _list.Count;
            InsertItem(index, item);
        }

        /// <inheritdoc/>
        public void Clear()
        {
            ClearItems();
        }

        /// <inheritdoc/>
        public bool Contains(T item) => _list.Contains(item);

        /// <inheritdoc/>
        public void CopyTo(T[] array, int arrayIndex) => _list.CopyTo(array, arrayIndex);

        /// <inheritdoc/>
        public bool Remove(T item)
        {
            int index = _list.IndexOf(item);
            if (index < 0) return false;
            RemoveItem(index);
            return true;
        }

        #endregion

        #region IList

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        bool IList.IsFixedSize => ((IList)_list).IsFixedSize;

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        bool IList.Contains(object? value) => ((IList)_list).Contains(value);

        /// <inheritdoc/>
        int IList.IndexOf(object? value) => ((IList)_list).IndexOf(value);

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        void IList.Remove(object? value)
        {
            if (IsCompatibleObject(value))
            {
                Remove((T)value!);
            }
        }

        #endregion

        #region ICollection

        /// <inheritdoc/>
        bool ICollection.IsSynchronized => false;

        /// <inheritdoc/>
        object ICollection.SyncRoot => ((ICollection)_list).SyncRoot;

        /// <inheritdoc/>
        void ICollection.CopyTo(Array array, int index) => ((ICollection)_list).CopyTo(array, index);

        #endregion

        #region IReadOnlyList<T>

        /// <inheritdoc/>
        T IReadOnlyList<T>.this[int index] => _list[index];

        #endregion

        #region IEnumerable

        /// <inheritdoc/>
        public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => ((IEnumerable<T>)_list).GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_list).GetEnumerator();

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
