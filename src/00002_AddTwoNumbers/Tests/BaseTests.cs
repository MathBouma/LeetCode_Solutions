namespace _00002_AddTwoNumbers.Tests;

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
        var list1 = ListUtilities.ConstructLinkedList(new int[] {3, 4, 2});
        var list2 = ListUtilities.ConstructLinkedList(new int[] {4, 6, 5});

        var expectedList = ListUtilities.ConstructLinkedList(new int [] {8, 0, 7});
         
        Assert.Equal(expectedList, _solution.AddTwoNumbers(list1, list2));
    }   
    
    [Fact]
    public void ProvidedTest2()
    {
        var list1 = ListUtilities.ConstructLinkedList(new int[] {0});
        var list2 = ListUtilities.ConstructLinkedList(new int[] {0});

        var expectedList = ListUtilities.ConstructLinkedList(new int [] {0});
         
        Assert.Equal(expectedList, _solution.AddTwoNumbers(list1, list2));
    }    
    
    [Fact]
    public void ProvidedTest3()
    {
        var list1 = ListUtilities.ConstructLinkedList(new int[] {9,9,9,9,9,9,9});
        var list2 = ListUtilities.ConstructLinkedList(new int[] {9,9,9,9});

        var expectedList = ListUtilities.ConstructLinkedList(new int [] {1,0,0,0,9,9,9,8});
         
        Assert.Equal(expectedList, _solution.AddTwoNumbers(list1, list2));
    }
}

