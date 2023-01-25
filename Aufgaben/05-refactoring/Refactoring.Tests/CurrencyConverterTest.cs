namespace Refactoring.Tests;

using System;
using Xunit;

public class CurrencyConverterTest
{
    [Fact]
    public void TestConvertToUSD()
    {
        // Arrange
        double amount = 100;
        double expected = 109.00000000000001;
        CurrencyConverter currencyConverter = new CurrencyConverter("USD");

        // Act
        double actual = currencyConverter.ConvertTo(amount);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestConvertToEUR()
    {
        // Arrange
        double amount = 100;
        double expected = 96;
        CurrencyConverter currencyConverter = new CurrencyConverter("EUR");

        // Act
        double actual = currencyConverter.ConvertTo(amount);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestConvertError()
    {
        // Arrange
        double amount = 100;
        double expected = 100;
        CurrencyConverter currencyConverter = new CurrencyConverter("RRR");

        // Assert
        Assert.Throws<ArgumentException>(() => Assert.Equal(expected, currencyConverter.ConvertTo(amount)));
    }
}