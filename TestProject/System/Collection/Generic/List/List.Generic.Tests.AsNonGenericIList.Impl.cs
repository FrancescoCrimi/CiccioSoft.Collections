using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Tests
{
    public class List_Generic_Tests_AsNonGenericIList_Impl : List_Generic_Tests_AsNonGenericIList
    {
        protected override bool Enumerator_Empty_UsesSingletonInstance => true;
        protected override bool Enumerator_Current_UndefinedOperation_Throws => true;
        protected override Type ICollection_NonGeneric_CopyTo_ArrayOfEnumType_ThrowType => typeof(ArgumentException);
        protected override bool Enumerator_Empty_ModifiedDuringEnumeration_ThrowsInvalidOperationException => false;
        protected override Type ICollection_NonGeneric_CopyTo_NonZeroLowerBound_ThrowType => typeof(ArgumentOutOfRangeException);

        protected override string CreateT(int seed)
        {
            int stringLength = seed % 10 + 5;
            Random rand = new Random(seed);
            byte[] bytes = new byte[stringLength];
            rand.NextBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
    }
}
