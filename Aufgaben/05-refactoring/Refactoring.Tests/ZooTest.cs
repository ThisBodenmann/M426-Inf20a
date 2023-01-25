using Refactoring.Animals;
using System;
using Xunit;

namespace Refactoring.Tests;

public class ZooTest
{
    [Fact]
    public void TestNoiseDog()
    {
        // Arrange
        Animal animal = new Dog("Tom");
        string expected = "Tom says 'woof'";

        // Act
        string actual = Zoo.MakeNoise(animal);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestNoiseCow()
    {
        // Arrange
        Animal animal = new Cow("Franz");
        string expected = "Franz says 'mooh'";

        // Act
        string actual = Zoo.MakeNoise(animal);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestGradingError()
    {
        // Arrange
        Animal animal = null;
        string expected = "Franz says 'mooh'";

        // Assert
        Assert.Throws<ArgumentException>(() => Assert.Equal(expected, Zoo.MakeNoise(animal)));
    }
}