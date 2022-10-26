using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoIsFive()
        {
            Assert.Equal(5, Calculator.Add(3, 2));
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            Assert.Equal(2, Calculator.Subtract(6, 4));
        }

        [Fact]
        public void TestMultiplyTwoAndThreeIsSix()
        {
            Assert.Equal(6, Calculator.Multiply(3, 2));
        }

        [Fact]
        public void TestDivideEightAndTwoIsFour()
        {
            Assert.Equal(4, Calculator.Divide(8, 2));
        }

        [Fact]
        public void TestDivideWithZero()
        {

            Assert.Throws<ArgumentException>(() => Assert.Equal(0, Calculator.Divide(8, 0)));
        }
    }
}
