using Xunit;

namespace Codility.Test;

public class BananaCountTest {

    [Theory]
    [InlineData("BANANA", 1)]
    [InlineData("BANANAANANA", 1)]
    [InlineData("QXBXXABNNAA", 1)]
    public void Test(string s, int count) {        
        Assert.Equal(BananaCounter.Solution(s), count);
    }
}