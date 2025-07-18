// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace CiccioSoft.Collections.Core.Tests
{
    public class GenericHashSet<T> : CiccioSoft.Collections.Core.HashSet<T>
    {
        public GenericHashSet()
        {
        }

        public GenericHashSet(IEqualityComparer<T>? comparer) : base(comparer)
        {
        }

#if NETCOREAPP2_1_OR_GREATER || NET472_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        public GenericHashSet(int capacity) : base(capacity)
        {
        }
#endif

        public GenericHashSet(IEnumerable<T> collection) : base(collection)
        {
        }

        public GenericHashSet(IEnumerable<T> collection, IEqualityComparer<T>? comparer) : base(collection, comparer)
        {
        }

#if NETCOREAPP2_1_OR_GREATER || NET472_OR_GREATER || NETSTANDARD2_1_OR_GREATER
        public GenericHashSet(int capacity, IEqualityComparer<T>? comparer) : base(capacity, comparer)
        {
        }
#endif
    }

}
