// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Tests;

namespace CiccioSoft.Collections.Tests.CollectionBase
{
    /// <summary>
    /// Contains tests that ensure the correctness of the List class.
    /// </summary>
    public class CollectionBase_Tests_AsNonGenericIList : IList_NonGeneric_Tests
    {
        #region IList_Generic_Tests

        protected override bool NullAllowed => true;

        protected override bool Enumerator_Empty_UsesSingletonInstance => true;
        protected override bool Enumerator_Current_UndefinedOperation_Throws => true;
        protected override Type ICollection_NonGeneric_CopyTo_ArrayOfEnumType_ThrowType => typeof(ArgumentException);
        protected override bool Enumerator_Empty_ModifiedDuringEnumeration_ThrowsInvalidOperationException => false;
        //protected override Type ICollection_NonGeneric_CopyTo_NonZeroLowerBound_ThrowType => typeof(ArgumentOutOfRangeException);


        protected override IList NonGenericIListFactory()
        {
            return GenericListFactory();
        }

        protected override IList NonGenericIListFactory(int count)
        {
            return GenericListFactory(count);
        }

        protected virtual CollectionBase<string> GenericListFactory()
        {
            return new CollectionBase<string>();
        }

        protected virtual CollectionBase<string> GenericListFactory(int count)
        {
            var list = GenericListFactory();
            int seed = 5321;
            while (list.Count < count)
                list.Add((string)CreateT(seed++));
            return list;
        }

        protected override string CreateT(int seed)
        {
            int stringLength = seed % 10 + 5;
            Random rand = new Random(seed);
            byte[] bytes = new byte[stringLength];
            rand.NextBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        #endregion
    }
}
