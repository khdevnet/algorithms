
var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
var r = SwapPairs(head);

Console.ReadLine();

ListNode SwapPairs(ListNode head)
{
    if (head == null) return null;
    if (head.next == null) return head;
    ListNode tail = new ListNode(head.val);
    ListNode newHead = new ListNode(head.next.val, tail);
    if (head.next?.next != null)
    {
        tail.next = SwapPairs(head.next.next);
    }
    return newHead;
}

ListNode SwapPairsLeetCode(ListNode head)
{
    // If the list has no node or has only one node left.
    if ((head == null) || (head.next == null))
    {
        return head;
    }

    // Nodes to be swapped
    ListNode firstNode = head;
    ListNode secondNode = head.next;
    // Swapping
    firstNode.next = SwapPairs(secondNode.next);
    secondNode.next = firstNode;
    // Now the head is the second node
    return secondNode;
}

// st1  2 3
// st2 3 4 new ListNode(head.next.val, null)
// st3 return null;


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

