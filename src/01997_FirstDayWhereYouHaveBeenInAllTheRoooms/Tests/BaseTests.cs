namespace _1997_FirstDayWhereYouHaveBeenInAllTheRoooms.Tests;

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
        var nextVisit = new[] {0,0};
        Assert.Equal(2, _solution.FirstDayBeenInAllRooms(nextVisit));
    }    
    
    [Fact]
    public void ProvidedExample2()
    {
        var nextVisit = new[] {0,0,2};
        Assert.Equal(6, _solution.FirstDayBeenInAllRooms(nextVisit));
    }    
    
    [Fact]
    public void ProvidedExample3()
    {
        var nextVisit = new[] {0,1,2,0};
        Assert.Equal(6, _solution.FirstDayBeenInAllRooms(nextVisit));
    }
}
