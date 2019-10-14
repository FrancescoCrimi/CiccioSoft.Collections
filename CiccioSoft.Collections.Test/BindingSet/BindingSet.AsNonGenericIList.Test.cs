using System;
using System.Collections;
using System.Collections.Tests;

namespace CiccioSoft.Collections.Generic.Test.BindingSet
{
    public class BindingSet_AsNonGenericIList_Test : IList_NonGeneric_Tests
    {
        protected override bool Enumerator_Current_UndefinedOperation_Throws => true;
        protected override Type ICollection_NonGeneric_CopyTo_ArrayOfEnumType_ThrowType => typeof(ArgumentException);
        protected override bool IsReadOnly => true;

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
            return new BindingSet<string>();
        }

        protected override IList NonGenericIListFactory(int count)
        {
            BindingSet<string> collection = new BindingSet<string>();
            int seed = 9600;
            while (collection.Count < count)
            {
                object toAdd = CreateT(seed++);
                collection.Add((string)toAdd);
            }
            return collection;
        }
    }
}
