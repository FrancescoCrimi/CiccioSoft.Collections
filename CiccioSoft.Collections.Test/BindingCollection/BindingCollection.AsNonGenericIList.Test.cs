using System;
using System.Collections;
using System.Collections.Tests;

namespace CiccioSoft.Collections.Generic.Test.BindingCollection
{
    public class BindingCollection_AsNonGenericIList_Test : IList_NonGeneric_Tests
    {
        protected override bool Enumerator_Current_UndefinedOperation_Throws => true;
        protected override bool IList_CurrentAfterAdd_Throws => false;
        protected override Type ICollection_NonGeneric_CopyTo_ArrayOfEnumType_ThrowType => typeof(ArgumentException);

        protected override object CreateT(int seed)
        {
            int stringLength = seed % 10 + 5;
            Random rand = new Random(seed);
            byte[] bytes = new byte[stringLength];
            rand.NextBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        protected override IList NonGenericIListFactory()
        {
            return new BindingCollection<string>();
        }
    }
}
