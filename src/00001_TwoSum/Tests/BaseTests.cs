namespace _1_TwoSum;

public abstract class BaseTests
{
    private ISolution _solution;

    protected BaseTests(ISolution solution)
    {
        _solution = solution;
    }
    
    [Fact]
    public void ProvidedTest1()
    {
        var nums = new[] { 2, 7, 11, 15 };
        var target = 9;
        var expected = new [] {0, 1};
        
        Assert.Equal(expected, _solution.TwoSum(nums, target));
    }
    
    [Fact]
    public void ProvidedTest2()
    {
        var nums = new[] { 3, 2, 4 };
        var target = 6;
        var expected = new [] {1, 2};
        
        Assert.Equal(expected, _solution.TwoSum(nums, target));
    }
    
    [Fact]
    public void ProvidedTest3()
    {        
        var nums = new[] {3, 3};
        var target = 6;
        var expected = new [] {0, 1};
        
        Assert.Equal(expected, _solution.TwoSum(nums, target));
    }

    [Fact]
    public void NegativeNumbersTest()
    {
        var nums = new[] { -1, -2, -3, -4, -5 };
        var target = -8;
        var expected = new[] {2, 4};
        
        Assert.Equal(expected, _solution.TwoSum(nums, target));
        
    }
}
