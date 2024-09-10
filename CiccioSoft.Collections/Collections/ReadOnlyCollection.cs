// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CiccioSoft.Collections
{
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class ReadOnlyCollection<T> : IList<T>, IList, IReadOnlyList<T>
    {
        protected readonly IList<T> _list; // Do not rename (binary serialization)

        #region Constructors

        public ReadOnlyCollection(IList<T> list)
        {
            if (list == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.list);
            }
            _list = list!;
        }

        #endregion

        #region Public Property

        /// <summary>Gets an empty <see cref="ReadOnlyCollection{T}"/>.</summary>
        /// <value>An empty <see cref="ReadOnlyCollection{T}"/>.</value>
        /// <remarks>The returned instance is immutable and will always be empty.</remarks>
        public static ReadOnlyCollection<T> Empty { get; } = new ReadOnlyCollection<T>(Array.Empty<T>());

        #endregion

        #region IReadOnlyList<T>

        public T this[int index] => _list[index];

        #endregion

        #region IReadOnlyCollection<T>

        public int Count => _list.Count;

        #endregion

        #region IList<T>

        T IList<T>.this[int index]
        {
            get => _list[index];
            set => ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        public int IndexOf(T value)
        {
            return _list.IndexOf(value);
        }

        void IList<T>.Insert(int index, T value)
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        void IList<T>.RemoveAt(int index)
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        #endregion

        #region ICollection<T>

        bool ICollection<T>.IsReadOnly => true;

        void ICollection<T>.Add(T value)
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        void ICollection<T>.Clear()
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        public bool Contains(T value)
        {
            return _list.Contains(value);
        }

        public void CopyTo(T[] array, int index)
        {
            _list.CopyTo(array, index);
        }

        bool ICollection<T>.Remove(T value)
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            return false;
        }

        #endregion

        #region IList

        object? IList.this[int index]
        {
            get => _list[index];
            set => ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        bool IList.IsFixedSize => true;

        bool IList.IsReadOnly => true;

        int IList.Add(object? value)
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
            return -1;
        }

        void IList.Clear()
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
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
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        void IList.Remove(object? value)
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        void IList.RemoveAt(int index)
        {
            ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
        }

        #endregion

        #region ICollection

        bool ICollection.IsSynchronized => false;

        object ICollection.SyncRoot => _list is ICollection coll ? coll.SyncRoot : this;

        void ICollection.CopyTo(Array array, int index) => CollectionHelpers.CopyTo(_list, array, index);

        #endregion

        #region IEnumerable methods

        public IEnumerator<T> GetEnumerator() =>
            _list.Count == 0 ? SZGenericArrayEnumerator<T>.Empty :
            _list.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
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
