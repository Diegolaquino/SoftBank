using System;
using Xunit;

namespace SoftBankTests
{
    public class ExampleUnitTest
    {
        [Fact(DisplayName = "My first Test")]
        public void Test1()
        {
            var t = true;

            Assert.True(t);
        }
    }
}
