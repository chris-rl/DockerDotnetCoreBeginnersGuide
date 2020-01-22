using System;
using MeetupLib;
using Xunit;

namespace MeetupLibTest
{
    public class CrazyCalculatorTest
    {
        private readonly CrazyCalculator _calculator = new CrazyCalculator();

        [Fact]
        public void AddAndMultiplyTest()
        {
            var result = _calculator.AddAndMultiply(2, 3);
            Assert.Equal(15, result);
        }
    }
}
