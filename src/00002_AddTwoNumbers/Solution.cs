namespace _00002_AddTwoNumbers;

public class Solution : ISolution
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var carry = 0;
        ListNode? currNode = null;
        ListNode? head = null;
        
        while (l1 != null || l2 != null || carry > 0)
        {
            var newVal =
                (l1?.val ?? 0) +
                (l2?.val ?? 0) +
                carry;

            var nextNode = new ListNode(newVal % 10);
            
            if (currNode != null) 
                currNode.next = nextNode;

            currNode = nextNode;
            head ??= currNode;

            carry = newVal > 9 ? 1 : 0;
            
            l1 = l1?.next;
            l2 = l2?.next;
        }

        GC.Collect();
        return head ?? throw new InvalidOperationException();
    }
}
