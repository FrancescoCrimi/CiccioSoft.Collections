// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Collections.Tests;

namespace CiccioSoft.Collections.Tests.Collection
{
    /// <summary>
    /// Contains tests that ensure the correctness of the List class.
    /// </summary>
    public abstract partial class Collection_Generic_Tests<T> : IList_Generic_Tests<T>
    {
        #region IList<T> Helper Methods

#if NET8_0_OR_GREATER
        protected override bool Enumerator_Empty_UsesSingletonInstance => true;
        protected override bool Enumerator_Empty_Current_UndefinedOperation_Throws => true;
        protected override bool Enumerator_Empty_ModifiedDuringEnumeration_ThrowsInvalidOperationException => false;
#endif

        protected override IList<T> GenericIListFactory()
        {
            return GenericCollectionFactory();
        }

        protected override IList<T> GenericIListFactory(int count)
        {
            return GenericCollectionFactory(count);
        }

        #endregion

        #region Collection<T> Helper Methods

        protected virtual Collection<T> GenericCollectionFactory()
        {
            return new Collection<T>();
        }

        protected virtual Collection<T> GenericCollectionFactory(int count)
        {
            IEnumerable<T> toCreateFrom = CreateEnumerable(EnumerableType.List, null, count, 0, 0);
            return new Collection<T>(toCreateFrom);
        }

        #endregion
    }
}
