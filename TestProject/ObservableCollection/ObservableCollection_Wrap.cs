using System.Collections.Generic;
using Xunit;

namespace CiccioSoft.Collections.Tests.ObservableCollection
{
    public class ObservableCollection_Wrap
    {
        [Fact]
        public void ObservableCollection_MS_Wrap_Test()
        {
            List<string> list1 = ["foo"];
            System.Collections.ObjectModel.ObservableCollection<string> collection1 = new(list1);
            Assert.Single(collection1);
            collection1.Add("bar");
            Assert.Single(list1);
        }

        [Fact]
        public void ObservableCollection_Ciccio_Wrap_Test()
        {
            List<string> list1 = ["foo"];
            ObservableCollection<string> collection1 = new(list1);
            Assert.Single(collection1);
            collection1.Add("bar");
            Assert.Single(list1);
        }
    }
}
