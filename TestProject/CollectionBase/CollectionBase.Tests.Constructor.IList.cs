using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Tests;
using Xunit;

namespace CiccioSoft.Collections.Tests.CollectionBase
{
    public abstract partial class CollectionBase_Tests<T> : IList_Generic_Tests<T>
    {
        [Fact]
        public void Constructor_Generic_IList()
        {
            List<string> list1 = ["foo"];
            CollectionBase<string> collection1 = new(list1);
            Assert.False(collection1.IsReadOnly);
            Assert.Single(collection1);
            list1.Add("bar");
            Assert.Equal(2, list1.Count);
            Assert.Equal(2, collection1.Count);
        }

        [Fact]
        public void Constructor_Array()
        {
            string[] arr = ["foo"];
            CollectionBase<string> collection3 = new CollectionBase<string>(arr);
            Assert.False(collection3.IsReadOnly);
            Assert.Single(collection3);
            collection3.Add("bar");
            Assert.Equal(2, collection3.Count);
        }

        [Fact]
        public void Collection_Generic_Constructor_IList_Array()
        {
            List<string> list1 = ["foo"];
            Collection<string> collection1 = new(list1);
            Assert.False(((IList<string>)collection1).IsReadOnly);
            Assert.Single(collection1);
            list1.Add("bar");
            Assert.Equal(2, list1.Count);
            Assert.Equal(2, collection1.Count);

            string[] arr = ["foo"];
            Collection<string> collection2 = new(arr);
            Assert.True(((IList<string>)collection2).IsReadOnly);
            Assert.Single(collection2);
        }


        [Fact]
        public void List_Generic_Constructor_IList_Array_()
        {
            List<string> list1 = ["foo"];
            List<string> collection1 = new(list1);
            Assert.False(((IList<string>)collection1).IsReadOnly);
            Assert.Single(collection1);
            list1.Add("bar");
            Assert.Equal(2, list1.Count);
            Assert.Single(collection1);

            string[] arr = ["foo"];
            List<string> collection2 = new(arr);
            Assert.False(((IList<string>)collection2).IsReadOnly);
            Assert.Single(collection2);
            collection2.Add("bar");
            Assert.Equal(2, collection2.Count);
        }
    }
}
