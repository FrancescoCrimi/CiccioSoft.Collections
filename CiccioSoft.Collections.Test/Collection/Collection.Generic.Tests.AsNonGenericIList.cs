// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Tests;

namespace CiccioSoft.Collections.Tests.ListBase
{
    /// <summary>
    /// Contains tests that ensure the correctness of the ListBase class.
    /// </summary>
    public class Collection_Generic_Tests_AsNonGenericIList : IList_NonGeneric_Tests
    {
        #region IList Helper methods

        protected override bool Enumerator_Current_UndefinedOperation_Throws => true;
        protected override Type ICollection_NonGeneric_CopyTo_ArrayOfIncorrectValueType_ThrowType => typeof(InvalidCastException);
        protected override Type ICollection_NonGeneric_CopyTo_ArrayOfIncorrectReferenceType_ThrowType => typeof(InvalidCastException);
        protected override Type ICollection_NonGeneric_CopyTo_NonZeroLowerBound_ThrowType => typeof(ArgumentOutOfRangeException);
        protected override bool IList_CurrentAfterAdd_Throws => false;

#if NET8_0_OR_GREATER
        protected override bool Enumerator_Empty_ModifiedDuringEnumeration_ThrowsInvalidOperationException => false;
        protected override bool Enumerator_Empty_UsesSingletonInstance => true;
        protected override bool IList_Empty_CurrentAfterAdd_Throws => true;
#endif

        protected override IList NonGenericIListFactory()
        {
            return new Collection<object>();
        }

        #endregion
    }
}
