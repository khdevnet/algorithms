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
        var merged = MergeTwoLists2(list1, list2);
        Console.ReadLine();
    }

    private static ListNode MergeTwoLists2(ListNode list1, ListNode list2)
    {
        ListNode head = new ListNode();
        ListNode tail = head;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next;
        }

        tail.next = list1 == null ? list2 : list1;

        return head.next;
    }

    private static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        ListNode mergedHead;
        if (list1.val < list2.val)
        {
            mergedHead = list1;
            list1 = list1.next;
        }
        else
        {
            mergedHead = list2;
            list2 = list2.next;
        }

        mergedHead.next = MergeTwoLists(list1, list2);

        return mergedHead;
    }
}