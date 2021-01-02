using System;
using Xunit;
using DevOpsPractWA.Models;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ValidateCustomerData()
        {
            var customerobj = new CustomerData(1, "Datta");
            Assert.Equal(1, customerobj.ID);
            Assert.Equal("Datta", customerobj.Name);
        }
    }
}
