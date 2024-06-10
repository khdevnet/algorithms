
var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
var r = SwapPairs(head);

Console.ReadLine();

ListNode SwapPairs(ListNode head)
{
    if (head.next == null) return head;
    var tail = head.next.next; // 3
    var b = head.next; // 2
    head.next = head; // 1
    head = b; //2

    return SwapPairs(tail);
}


class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

