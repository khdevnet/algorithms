internal class Program
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    private static void Main(string[] args)
    {
        // Input: list1 = [1,2,4], list2 = [1,3,4]
        // Output: [1,1,2,3,4,4]

        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var merged = MergeTwoLists(list1, list2);
        Console.ReadLine();
    }

    private static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1.next == null && list2.next != null) return list2;
        if (list1.next != null && list2.next == null) return list1;
        var merged = new ListNode();
        while (list1.next != null && list2.next != null)
        {
            if (list1.val <= list2.val)
            {
                merged.val = list1.val; 
                merged.next = new ListNode(list2.val);
                merged = merged.next;
                list1 = list1.next;
                list2 = list2.next;
            }

        }
        return list1;
    }
}