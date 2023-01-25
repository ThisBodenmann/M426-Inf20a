namespace Refactoring.Tests;

using System;
using Xunit;

public class GradingTest 
{
    [Fact]
    public void TestGradingB()
    {
        // Arrange
        int grade = 2;
        char expected = 'B';
        Grading grading = new Grading();

        // Act
        char actual = Grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestGradingC()
    {
        // Arrange
        int grade = 3;
        char expected = 'C';
        Grading grading = new Grading();

        // Act
        char actual = Grading.GetLetterGrade(grade);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestGradingError()
    {
        // Arrange
        int grade = 10;
        char expected = 'C';
        Grading grading = new Grading();

        // Assert
        Assert.Throws<ArgumentException>(() => Assert.Equal(expected, Grading.GetLetterGrade(grade)));
    }
}