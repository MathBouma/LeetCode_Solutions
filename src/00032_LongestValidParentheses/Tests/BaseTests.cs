namespace _00032_LongestValidParentheses.Tests;

public abstract class BaseTests
{
    private readonly ISolution _solution;

    protected BaseTests(ISolution solution)
    {
        _solution = solution;
    }

    [Fact]
    public void ProvidedExample1()
    {
        var s = "(()";
        Assert.Equal(2, _solution.LongestValidParentheses(s));
    }

    [Fact]
    public void ProvidedExample2()
    {

        var s = ")()())";
        Assert.Equal(4, _solution.LongestValidParentheses(s));
    }

    [Fact]
    public void ProvidedExample3()
    {

        var s = "";
        Assert.Equal(0, _solution.LongestValidParentheses(s));
    }

        [Fact]
    public void ProvidedExample4()
    {

        var s = "()()";
        Assert.Equal(4, _solution.LongestValidParentheses(s));
    }


        [Fact]
    public void ProvidedExample5()
    {

        var s = "()(())";
        Assert.Equal(6, _solution.LongestValidParentheses(s));
    }
        [Fact]
    public void ProvidedExample6()
    {

        var s = "()(()";
        Assert.Equal(2, _solution.LongestValidParentheses(s));
    }

    [Fact]
    public void ProvidedExample7()
    {
        var s = "((()))())";
        Assert.Equal(8, _solution.LongestValidParentheses(s));
    }
}
