// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Collections.Tests;
using System.Linq;
using Xunit;

namespace CiccioSoft.Collections.Tests.Collection
{
    /// <summary>
    /// Contains tests that ensure the correctness of the List class.
    /// </summary>
    public abstract partial class Collection_Generic_Tests<T> : IList_Generic_Tests<T>
    {
        #region Helpers

        public delegate int IndexOfDelegate(Collection<T> list, T value);
        public enum IndexOfMethod
        {
            IndexOf_T,
        };

        private IndexOfDelegate IndexOfDelegateFromType(IndexOfMethod methodType)
        {
            switch (methodType)
            {
                case (IndexOfMethod.IndexOf_T):
                    return ((Collection<T> list, T value) => { return list.IndexOf(value); });
                default:
                    throw new Exception("Invalid IndexOfMethod");
            }
        }

        /// <summary>
        /// MemberData for a Theory to test the IndexOf methods for List. To avoid high code reuse of tests for the 6 IndexOf
        /// methods in List, delegates are used to cover the basic behavioral cases shared by all IndexOf methods. A bool
        /// is used to specify the ordering (front-to-back or back-to-front (e.g. LastIndexOf)) that the IndexOf method
        /// searches in.
        /// </summary>
        public static IEnumerable<object[]> IndexOfTestData()
        {
            foreach (object[] sizes in ValidCollectionSizes())
            {
                int count = (int)sizes[0];
                yield return new object[] { IndexOfMethod.IndexOf_T, count, true };
            }
        }

        #endregion

        #region IndexOf

        [Theory]
        [MemberData(nameof(IndexOfTestData))]
        public void IndexOf_NoDuplicates(IndexOfMethod indexOfMethod, int count, bool frontToBackOrder)
        {
            _ = frontToBackOrder;
            Collection<T> list = GenericListFactory(count);
            List<T> expectedList = list.ToList();
            IndexOfDelegate IndexOf = IndexOfDelegateFromType(indexOfMethod);

            Assert.All(Enumerable.Range(0, count), i =>
            {
                Assert.Equal(i, IndexOf(list, expectedList[i]));
            });
        }

        [Theory]
        [MemberData(nameof(IndexOfTestData))]
        public void IndexOf_NonExistingValues(IndexOfMethod indexOfMethod, int count, bool frontToBackOrder)
        {
            _ = frontToBackOrder;
            Collection<T> list = GenericListFactory(count);
            IEnumerable<T> nonexistentValues = CreateEnumerable(EnumerableType.List, list, count: count, numberOfMatchingElements: 0, numberOfDuplicateElements: 0);
            IndexOfDelegate IndexOf = IndexOfDelegateFromType(indexOfMethod);

            Assert.All(nonexistentValues, nonexistentValue =>
            {
                Assert.Equal(-1, IndexOf(list, nonexistentValue));
            });
        }

        [Theory]
        [MemberData(nameof(IndexOfTestData))]
        public void IndexOf_DefaultValue(IndexOfMethod indexOfMethod, int count, bool frontToBackOrder)
        {
            _ = frontToBackOrder;
            T defaultValue = default;
            Collection<T> list = GenericListFactory(count);
            IndexOfDelegate IndexOf = IndexOfDelegateFromType(indexOfMethod);
            while (list.Remove(defaultValue))
                count--;
            list.Add(defaultValue);
            Assert.Equal(count, IndexOf(list, defaultValue));
        }

        #endregion
    }
}
