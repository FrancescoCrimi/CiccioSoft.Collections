// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CiccioSoft.Collections.Core
{
    [Serializable]
    [DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class ReadOnlyCollection<T> : IList<T>, IList, IReadOnlyList<T>
    {
        protected readonly Collection<T> _list; // Do not rename (binary serialization)

        #region Constructors

        public ReadOnlyCollection(Collection<T> list)
        {
            _list = list ?? throw new ArgumentNullException(nameof(list))!;
        }

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

        void ICollection.CopyTo(Array array, int index) => ((ICollection)_list).CopyTo(array, index);

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
            return value is T || value == null && default(T) == null;
        }

        #endregion
    }
}
