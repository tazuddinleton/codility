using Xunit;
namespace Codility.Test;

public class CalculatorTest {
    [Fact]
    public void ShouldAddWhenTwoNumbersAreGiven() {
        Assert.Equal(10, Calculator.Add(6, 4));
    }
}