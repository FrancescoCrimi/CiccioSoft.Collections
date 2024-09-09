using Xunit;

namespace System.ComponentModel.Tests
{
    public partial class BindingList_Test
    {
        [Fact]
        public void AddNew_Invoke_ThrowsNotSupportedException()
        {
            var bindingList = new BindingList<object>();
            Assert.Throws<NotSupportedException>(() =>
            {
                bindingList.AddNew();
            });
        }
    }
}
