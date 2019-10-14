using System;
using System.Collections.Generic;
using System.Collections.Tests;

namespace CiccioSoft.Collections.Generic.Test.BindingSet
{
    public abstract class BindingSet_Test : ISet_Generic_Tests<string>
    {
        protected override bool ResetImplemented => true;

        protected override ISet<string> GenericISetFactory()
        {
            return new BindingSet<string>();
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
