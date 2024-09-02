using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CiccioSoft.Collections.Tests.BindingList
{
    public partial class BindingList_Test
    {
        [Fact]
        public void AddNew_Invoke__ThrowsNotSupportedException()
        {
            var bindingList = new BindingList<object>();
            Assert.Throws<NotSupportedException>(() =>
            {
                bindingList.AddNew();
            });
        }
    }
}
