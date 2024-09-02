using CiccioSoft.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CiccioSoft.Collections.Generic.Test.BindingCollection
{
    public class BindingCollection_Wrap_Test
    {
        [Fact]
        public void BindingList_Wrap()
        {
            var list1 = new List<string>() { "foo" };
            var collection1 = new BindingList<string>(list1);
            Assert.Single(collection1);
            collection1.Add("bar");
            Assert.Equal(2, list1.Count);
        }

        [Fact]
        public void BindingCollection_Wrap()
        {
            var list1 = new List<string>() { "foo" };
            var collection1 = new BindingCollection<string>(list1);
            Assert.Single(collection1);
            collection1.Add("bar");
            Assert.Equal(2, list1.Count);
        }
    }
}
