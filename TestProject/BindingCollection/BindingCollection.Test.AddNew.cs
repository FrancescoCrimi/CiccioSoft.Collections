using System;
using Xunit;

namespace CiccioSoft.Collections.Tests.BindingCollection
{
    public partial class BindingCollection_Test
    {
        [Fact]
        public void AddNew_Invoke__ThrowsNotSupportedException()
        {
            var bindingList = new BindingCollection<object>();
            Assert.Throws<NotSupportedException>(() =>
            {
                bindingList.AddNew();
            });
        }
    }
}
