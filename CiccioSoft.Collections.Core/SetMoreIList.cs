using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CiccioSoft.Collections.Core
{
    public abstract class SetMoreIList<T> : Set<T>, IList
    {
        #region Constructors

        protected SetMoreIList() { }

        protected SetMoreIList(IEqualityComparer<T>? comparer) : base(comparer) { }

#if NET472_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NET6_0_OR_GREATER
        protected SetMoreIList(int capacity) : base(capacity) { }
#endif

        protected SetMoreIList(IEnumerable<T> collection) : base(collection) { }

        protected SetMoreIList(IEnumerable<T> collection, IEqualityComparer<T>? comparer) : base(collection, comparer) { }

#if NET472_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NET6_0_OR_GREATER
        protected SetMoreIList(int capacity, IEqualityComparer<T>? comparer) : base(capacity, comparer) { }
#endif

        #endregion

        #region IList Non Generic Members

        object? IList.this[int index]
        {
            get => items.ToList()[index];
            set => throw new NotSupportedException("Mutating a value collection derived from a hashset is not allowed.");
        }

        bool IList.IsFixedSize => false;

        bool IList.IsReadOnly => false;

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

            return items.ToList().IndexOf(item);
        }

        void IList.Clear() => ClearItems();

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
                return items.ToList().IndexOf((T)value!);
            }
            return -1;
        }

        void IList.Insert(int index, object? value)
        {
            throw new NotSupportedException("Mutating a value collection derived from a hashset is not allowed.");
        }

        void IList.Remove(object? value)
        {
            if (IsCompatibleObject(value))
            {
                Remove((T)value!);
            }
        }

        void IList.RemoveAt(int index)
        {
            throw new NotSupportedException("Mutating a value collection derived from a hashset is not allowed.");
        }

        #endregion

        #region Private

        private static bool IsCompatibleObject(object? value)
        {
            // Non-null values are fine.  Only accept nulls if T is a class or Nullable<U>.
            // Note that default(T) is not equal to null for value types except when T is Nullable<U>.
            return value is T || value == null && default(T) == null;
        }

        #endregion
    }
}
