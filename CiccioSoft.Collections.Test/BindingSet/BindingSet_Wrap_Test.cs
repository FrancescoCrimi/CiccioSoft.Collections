using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CiccioSoft.CiccioCollection.Test.BindingSet
{
    public class BindingSet_Wrap_Test
    {
        [Fact]
        public void BindingSet_Wrap()
        {
            var set = new HashSet<string>();
            set.Add("foo");
            //var binding = new BindingSet<string>(set);
            Assert.True(true);
        }
    }
}
