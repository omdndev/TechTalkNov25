namespace ConsoleApp1.Tests;

public class CalcTests
{
    private readonly Calc _calc;

    public CalcTests()
    {
        _calc = new Calc();
    }

    [Fact]
    public void Add_WithPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 2;

        // Act
        int result = _calc.Add(a, b);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void Add_WithNegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = -5;
        int b = -3;

        // Act
        int result = _calc.Add(a, b);

        // Assert
        Assert.Equal(-8, result);
    }

    [Fact]
    public void Add_WithMixedNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = 10;
        int b = -3;

        // Act
        int result = _calc.Add(a, b);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void Add_WithZero_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 0;

        // Act
        int result = _calc.Add(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(1, 1, 2)]
    [InlineData(100, 200, 300)]
    [InlineData(-50, 50, 0)]
    [InlineData(int.MaxValue, 0, int.MaxValue)]
    [InlineData(int.MinValue, 0, int.MinValue)]
    public void Add_WithVariousInputs_ReturnsExpectedResult(int a, int b, int expected)
    {
        // Act
        int result = _calc.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Subtract_WithPositiveNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        int a = 10;
        int b = 3;

        // Act
        int result = _calc.Subtract(a, b);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void Subtract_WithNegativeNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        int a = -5;
        int b = -3;

        // Act
        int result = _calc.Subtract(a, b);

        // Assert
        Assert.Equal(-2, result);
    }

    [Fact]
    public void Subtract_WithMixedNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        int a = 10;
        int b = -3;

        // Act
        int result = _calc.Subtract(a, b);

        // Assert
        Assert.Equal(13, result);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(5, 5, 0)]
    [InlineData(100, 50, 50)]
    [InlineData(-50, -50, 0)]
    [InlineData(0, 10, -10)]
    public void Subtract_WithVariousInputs_ReturnsExpectedResult(int a, int b, int expected)
    {
        // Act
        int result = _calc.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
