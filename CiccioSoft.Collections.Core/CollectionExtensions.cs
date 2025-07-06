using CiccioSoft.Collections.Core;
using System;
using System.Collections.Generic;

namespace CiccioSoft.Collections
{
    /// <summary>
    /// Backported collection extension methods for .NET versions prior to 10.0.
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        /// Returns a read-only <see cref="ReadOnlySet{T}"/> wrapper
        /// for the specified set.
        /// </summary>
        /// <typeparam name="T">The type of elements in the set.</typeparam>
        /// <param name="set">The set to wrap.</param>
        /// <returns>An object that acts as a read-only wrapper around the current <see cref="ISet{T}"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="set"/> is null.</exception>
        public static ReadOnlySet<T> AsReadOnly<T>(this ISet<T> set) =>
            new ReadOnlySet<T>(set);
    }
}
