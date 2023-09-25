namespace _00003_LongestSubstringWithoutRepeatingCharacters.Tests;

public abstract class BaseTests
{
    private readonly ISolution _solution;

    protected BaseTests(ISolution solution)
    {
        _solution = solution;
    }

    [Fact]
    public void ProvidedTest1()
    {
        var testString = "abcabcbb";
        var expectedValue = 3;
        
        Assert.Equal(expectedValue, _solution.LengthOfLongestSubstring(testString));
    }
    
    [Fact]
    public void ProvidedTest2()
    {
        var testString = "bbbbb";
        var expectedValue = 1;
        
        Assert.Equal(expectedValue, _solution.LengthOfLongestSubstring(testString));
    }
    
    [Fact]
    public void ProvidedTest3()
    {
        var testString = "pwwkew";
        var expectedValue = 3;
        
        Assert.Equal(expectedValue, _solution.LengthOfLongestSubstring(testString));
    }
}
