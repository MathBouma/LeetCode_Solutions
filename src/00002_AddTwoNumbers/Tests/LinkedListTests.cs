namespace _00002_AddTwoNumbers.Tests;

public class LinkedListTests
{
    [Fact]
    void LinkedListGeneratesCorrect()
    {
        var list1 = new[] { 1, 2, 3 };
        var linkedList = ListUtilities.ConstructLinkedList(list1);
        
        Assert.Equal(3, linkedList.val);
        Assert.Equal(2, linkedList.next?.val);;
        Assert.Equal(1, linkedList.next?.next?.val);
    }

    [Fact]
    void LinkedListEqualityPasses()
    {
        
        var list1 = new[] { 1, 2, 3 };
        var linkedList = ListUtilities.ConstructLinkedList(list1);
        
        var list2 = new[] { 1, 2, 3 };
        var linkedList2 = ListUtilities.ConstructLinkedList(list2);
        
        Assert.Equal(linkedList, linkedList2);
    }
    
    [Fact]
    void LinkedListEqualityFailsMixedLengths1()
    {
        
        var list1 = new[] { 1, 2, 3, 4 };
        var linkedList = ListUtilities.ConstructLinkedList(list1);
        
        var list2 = new[] { 1, 2, 3 };
        var linkedList2 = ListUtilities.ConstructLinkedList(list2);
        
        Assert.NotEqual(linkedList, linkedList2);
    }
    
    [Fact]
    void LinkedListEqualityFailsMixedLengths2()
    {
        
        var list1 = new[] { 1, 2, 3};
        var linkedList = ListUtilities.ConstructLinkedList(list1);
        
        var list2 = new[] { 1, 2, 3, 5 };
        var linkedList2 = ListUtilities.ConstructLinkedList(list2);
        
        Assert.NotEqual(linkedList, linkedList2);
    }
    
    [Fact]
    void LinkedListEqualityFails()
    {
        
        var list1 = new[] { 1, 2, 3 };
        var linkedList = ListUtilities.ConstructLinkedList(list1);
        
        var list2 = new[] { 1, 2, 4 };
        var linkedList2 = ListUtilities.ConstructLinkedList(list2);
        
        Assert.NotEqual(linkedList, linkedList2);
    }
}
