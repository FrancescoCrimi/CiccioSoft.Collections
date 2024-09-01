//using CiccioSoft.Collections.Generic;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CiccioSoft.Collections.Tests.BindingList
{
    public partial class BindingListTest
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
