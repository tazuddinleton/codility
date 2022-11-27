
using Codility.App;
using Xunit;
namespace Codility.Test;


public class ValidParenthesesTest {

    [Fact]
    
    public void ShouldReturnTrueWhenGivenValidString() {

        Assert.True(ValidParentheses.IsValid("()"));
        Assert.True(ValidParentheses.IsValid("(){}"));
        Assert.False(ValidParentheses.IsValid("(){"));
    }
}