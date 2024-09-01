using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiccioSoft.Collections
{
    /// <summary>
    ///     A hash set that implements the interfaces required for Entity Framework to use notification based change tracking
    ///     for a collection navigation property.
    /// </summary>
    /// <remarks>
    ///     See <see href="https://aka.ms/efcore-docs-local-views">Local views of tracked entities in EF Core</see> for more information and
    ///     examples.
    /// </remarks>
    /// <typeparam name="T">The type of elements in the hash set.</typeparam>
    public class CiccioHashSet<T> : ISet<T>
    {
        private HashSet<T> _set;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CiccioHashSet{T}" /> class
        ///     that is empty and uses the default equality comparer for the set type.
        /// </summary>
        public CiccioHashSet()
        : this(EqualityComparer<T>.Default)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CiccioHashSet{T}" /> class
        ///     that is empty and uses the specified equality comparer for the set type.
        /// </summary>
        /// <param name="comparer">
        ///     The <see cref="IEqualityComparer{T}" /> implementation to use when
        ///     comparing values in the set, or null to use the default <see cref="IEqualityComparer{T}" />
        ///     implementation for the set type.
        /// </param>
        public CiccioHashSet(IEqualityComparer<T> comparer)
        {
            _set = new HashSet<T>(comparer);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CiccioHashSet{T}" /> class
        ///     that uses the default equality comparer for the set type, contains elements copied
        ///     from the specified collection, and has sufficient capacity to accommodate the
        ///     number of elements copied.
        /// </summary>
        /// <param name="collection">The collection whose elements are copied to the new set.</param>
        public CiccioHashSet(IEnumerable<T> collection)
            : this(collection, EqualityComparer<T>.Default)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CiccioHashSet{T}" /> class
        ///     that uses the specified equality comparer for the set type, contains elements
        ///     copied from the specified collection, and has sufficient capacity to accommodate
        ///     the number of elements copied.
        /// </summary>
        /// <param name="collection">The collection whose elements are copied to the new set.</param>
        /// <param name="comparer">
        ///     The <see cref="IEqualityComparer{T}" /> implementation to use when
        ///     comparing values in the set, or null to use the default <see cref="IEqualityComparer{T}" />
        ///     implementation for the set type.
        /// </param>
        public CiccioHashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
        {
            _set = new HashSet<T>(collection, comparer);
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public bool Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public void ExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public bool SetEquals(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public void UnionWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
