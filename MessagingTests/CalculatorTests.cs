using MessagingApp.Services;

namespace MessagingTests;

public class CalculatorTests
{
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
}
