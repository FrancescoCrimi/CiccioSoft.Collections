// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Tests;

namespace CiccioSoft.Collections.Tests.ListBase
{
    /// <summary>
    /// Contains tests that ensure the correctness of the ListBase class.
    /// </summary>
    public class ListBase_Tests_AsNonGenericIList : IList_NonGeneric_Tests
    {
        #region IList_Generic_Tests

        protected override bool NullAllowed => true;

        protected override bool Enumerator_Current_UndefinedOperation_Throws => true;

        protected override IList NonGenericIListFactory()
        {
            return new ListBase<object>();
        }

        protected override IList NonGenericIListFactory(int count)
        {
            var list = NonGenericIListFactory();
            int seed = 5321;
            while (list.Count < count)
                list.Add(CreateT(seed++));
            return list;
        }

        //protected virtual List<string> GenericListFactory()
        //{
        //    return new List<string>();
        //}

        //protected virtual List<string> GenericListFactory(int count)
        //{
        //    var list = GenericListFactory();
        //    int seed = 5321;
        //    while (list.Count < count)
        //        list.Add((string)CreateT(seed++));
        //    return list;
        //}

        protected override object CreateT(int seed)
        {
            if (seed % 2 == 0)
            {
                int stringLength = seed % 10 + 5;
                Random rand = new Random(seed);
                byte[] bytes = new byte[stringLength];
                rand.NextBytes(bytes);
                return Convert.ToBase64String(bytes);
            }
            else
            {
                Random rand = new Random(seed);
                return rand.Next();
            }
        }

        #endregion
    }
}
