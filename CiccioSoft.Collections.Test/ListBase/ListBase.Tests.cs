// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Collections.Tests;

namespace CiccioSoft.Collections.Tests.ListBase
{
    /// <summary>
    /// Contains tests that ensure the correctness of the List class.
    /// </summary>
    public abstract partial class ListBase_Tests<T> : IList_Generic_Tests<T>
    {
        #region IList<T> Helper Methods

#if NET8_0
        protected override bool Enumerator_Empty_UsesSingletonInstance => true;
#else
        protected override bool Enumerator_Empty_UsesSingletonInstance => false;
#endif
        //protected override bool Enumerator_Empty_Current_UndefinedOperation_Throws => true;
        //protected override bool Enumerator_Empty_ModifiedDuringEnumeration_ThrowsInvalidOperationException => false;

        protected override IList<T> GenericIListFactory()
        {
            return GenericListFactory();
        }

        protected override IList<T> GenericIListFactory(int count)
        {
            return GenericListFactory(count);
        }

        #endregion

        #region ListBase<T> Helper Methods

        protected virtual ListBase<T> GenericListFactory()
        {
            return new ListBase<T>();
        }

        protected virtual ListBase<T> GenericListFactory(int count)
        {
            IEnumerable<T> toCreateFrom = CreateEnumerable(EnumerableType.List, null, count, 0, 0);
            return new ListBase<T>(toCreateFrom);
        }

        #endregion
    }
}
