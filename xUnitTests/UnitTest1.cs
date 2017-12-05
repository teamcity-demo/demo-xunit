using System;
using Xunit;

namespace xUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_TowNumber_Result_Expected()
        {
            var num1 = 10;
            var num2 = 30;

            var expected = 40;

            var result = num1 + num2;

            Assert.True(expected == result, "Result is ok!");
            Assert.Equal(expected, result);
        }
    }
}
