// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CiccioSoft.Collections.Core
{
    /// <summary>
    /// Provides the base class for a generic collection.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class Collection<T> : IList<T>, IList, IReadOnlyList<T>
    {
        protected readonly List<T> items;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref = "Collection{T}" /> class that is empty and has the default initial capacity.
        /// </summary>
        public Collection()
        {
            items = new List<T>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Collection{T}" /> class that contains elements copied from the specified collection and has sufficient capacity to accommodate the number of elements copied.
        /// </summary>
        /// <param name = "collection" > The collection whose elements are copied to the new list.</param>
        /// <exception cref = "ArgumentNullException" >
        /// <paramref name="collection" /> is <see langword = "null" />
        /// </exception>
        public Collection(IEnumerable<T> collection)
        {
            items = new List<T>(collection);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Collection{T}" /> class that is empty and has the specified initial capacity.
        /// </summary>
        /// <param name = "capacity" > The number of elements that the new list can initially store.</param>
        /// <exception cref = "ArgumentOutOfRangeException" >
        /// <paramref name = "capacity" /> is less than 0.
        /// </exception>
        public Collection(int capacity)
        {
            items = new List<T>(capacity);
        }

        #endregion

        #region Public Property

        /// <summary>
        /// Gets or sets the total number of elements the internal data structure can hold without resizing.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <see cref="Collection{T}.Capacity" /> is set to a value that is less than <see cref="Collection{T}.Count" />.
        /// </exception>
        /// <exception cref="OutOfMemoryException">
        /// There is not enough memory available on the system.
        /// </exception>
        /// <returns>
        /// The number of elements that the <see cref="Collection{T}" /> can contain before resizing is required.
        /// </returns>
        public int Capacity
        {
            get => items.Capacity;
            set => items.Capacity = value;
        }

        #endregion

        #region Public Method

        /// <summary>
        /// Returns a read-only <see cref="ReadOnlyCollection{T}" /> wrapper for the current collection.
        /// </summary>
        /// <returns>
        /// An object that acts as a read-only wrapper around the current <see cref="Collection{T}" />.
        /// </returns>
        public ReadOnlyCollection<T> AsReadOnly()
        {
            return new ReadOnlyCollection<T>(this);
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

        #region IList<T>

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public int IndexOf(T item) => items.IndexOf(item);

        /// <inheritdoc/>
        public void Insert(int index, T item)
        {
            if ((uint)index > (uint)items.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
            }

            InsertItem(index, item);
        }

        /// <inheritdoc/>
        public void RemoveAt(int index)
        {
            if ((uint)index >= (uint)items.Count)
            {
                ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
            }

            RemoveItem(index);
        }

        #endregion

        #region ICollection<T>

        /// <inheritdoc/>
        public int Count => items.Count;

        /// <inheritdoc/>
        public bool IsReadOnly => false;

        /// <inheritdoc/>
        public void Add(T item)
        {
            int index = items.Count;
            InsertItem(index, item);
        }

        /// <inheritdoc/>
        public void Clear()
        {
            ClearItems();
        }

        /// <inheritdoc/>
        public bool Contains(T item) => items.Contains(item);

        /// <inheritdoc/>
        public void CopyTo(T[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);

        /// <inheritdoc/>
        public bool Remove(T item)
        {
            int index = items.IndexOf(item);
            if (index < 0) return false;
            RemoveItem(index);
            return true;
        }

        #endregion

        #region IList

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        bool IList.IsFixedSize => ((IList)items).IsFixedSize;

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

            return Count - 1;
        }

        /// <inheritdoc/>
        bool IList.Contains(object? value) => ((IList)items).Contains(value);

        /// <inheritdoc/>
        int IList.IndexOf(object? value) => ((IList)items).IndexOf(value);

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
        object ICollection.SyncRoot => ((ICollection)items).SyncRoot;

        /// <inheritdoc/>
        void ICollection.CopyTo(Array array, int index) => ((ICollection)items).CopyTo(array, index);

        #endregion

        #region IReadOnlyList<T>

        /// <inheritdoc/>
        T IReadOnlyList<T>.this[int index] => items[index];

        #endregion

        #region IEnumerable

        /// <inheritdoc/>
        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => ((IEnumerable<T>)items).GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)items).GetEnumerator();

        #endregion

        #region Private Method

        private static bool IsCompatibleObject(object? value)
        {
            // Non-null values are fine.  Only accept nulls if T is a class or Nullable<U>.
            // Note that default(T) is not equal to null for value types except when T is Nullable<U>.
            return value is T || value == null && default(T) == null;
        }

        #endregion
    }
}
