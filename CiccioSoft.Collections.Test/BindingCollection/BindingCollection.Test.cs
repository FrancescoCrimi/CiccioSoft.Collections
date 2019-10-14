using System;
using System.Collections.Generic;
using System.Collections.Tests;

namespace CiccioSoft.Collections.Generic.Test.BindingCollection
{
    public abstract class BindingCollection_Test : IList_Generic_Tests<string>
    {
        protected override IList<string> GenericIListFactory()
        {
            return new BindingCollection<string>();
        }

        protected override IList<string> GenericIListFactory(int count)
        {
            IEnumerable<string> toCreateFrom = CreateEnumerable(EnumerableType.List, null, count, 0, 0);
            return new BindingCollection<string>(toCreateFrom);
        }

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
