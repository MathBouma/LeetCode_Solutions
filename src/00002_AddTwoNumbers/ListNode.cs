namespace _00002_AddTwoNumbers;

public class ListNode : IEquatable<ListNode>
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public bool Equals(ListNode? other)
    {
        if (other == null)
            return false;
        
        return
            (val == other.val) &&
            (
            (next == null && other.next == null) ||
            (next.Equals(other.next)));
    }

    public override string ToString()
    {
        return $"{val} => {next}";
    }
    
    public int GetHashCode(ListNode obj)
    {
        return HashCode.Combine(obj.val, obj.next);
    }
}

public class ListUtilities
{
   
    public static ListNode ConstructLinkedList(int[] vals)
    {
        return vals.Aggregate<int, ListNode?>(null, (current, i) => new ListNode(i, current)) ?? throw new InvalidOperationException();
    } 
}
