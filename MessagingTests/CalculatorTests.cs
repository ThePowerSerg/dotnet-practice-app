using MessagingApp.Services;

namespace MessagingTests;

public class CalculatorTests
{
    // Test IsEven
    [Fact]
    public void IsEvenTest()
    {
        var calculator = new CalculatorService();

        int x = 1;
        int y = 2;

        var xResult = calculator.IsEven(x);

        var yResult = calculator.IsEven(y);

        Assert.False(xResult);
        Assert.True(yResult);
    }

    // Test DiffTest
    [Theory]
    [InlineData(1, 2, 1)]
    [InlineData(2, 4, 2)]
    public void DiffTest(int x, int y, int expectedValue)
    {
        var calculator = new CalculatorService();
        var result = calculator.Diff(x, y);
        Assert.Equal(expectedValue, result);
    }

    // Test Add
    [Theory]
    [InlineData(15, 10, 5)]
    public void AddTest(int expectedValue, int x, int y)
    {
        var calculator = new CalculatorService();
        var result = calculator.Add(x, y);
        Assert.Equal(expectedValue, result);
    }

    // Test Add
    [Theory]
    [MemberData(nameof(CalculatorService.Data), MemberType = typeof(CalculatorService))]
    public void AddMemberDataTest(int expectedValue, int x, int y)
    {
        var calculator = new CalculatorService();
        var result = calculator.Add(x, y);
        Assert.Equal(expectedValue, result);
    }

    // Test Add
    [Theory(Skip = "Obsolete logic")]
    [ClassData(typeof(CalculatorService))]
    public void AddClassDataTest(int expectedValue, int x, int y)
    {
        var calculator = new CalculatorService();
        var result = calculator.Add(x, y);
        Assert.Equal(expectedValue, result);
    }

    // Test Add
    [Theory]
    [InlineData(8, 8, 8)]
    public void AverageTest(int expectedValue, int x, int y)
    {
        var calculator = new CalculatorService();
        var result = calculator.Average(x, y);
        Assert.Equal(expectedValue, result);
    }


    // Sum Test
    [Theory]
    [InlineData(7, 4, 3)]
    [InlineData(-5, -3, -2)]
    public void SumTest(int expectedValue, params int[] values)
    {
        var calculator = new CalculatorService();
        var result = calculator.Sum(values);
        Assert.Equal(expectedValue, result);
    }
}


