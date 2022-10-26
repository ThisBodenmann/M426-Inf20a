using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
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
