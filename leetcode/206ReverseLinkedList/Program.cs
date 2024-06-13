// Input: head = [1,2,3,4,5]
// Output: [5,4,3,2,1]

var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
var reversedHead = ReverseListLoop(head);
while (reversedHead.next != null)
{
    Console.Write(reversedHead.val + "->");
    reversedHead = reversedHead.next;
}

Console.ReadLine();

// head  head.next   head.next.next   head.next.next.next 
//         ! 
//        head       head.next        head.next.next
// 1|* -> 2|*->      3|* ->           null
//                                    <-*|2
ListNode ReverseList(ListNode head)
{
    if (head == null || head.next == null)
    {
        return head;
    }
    var tail = ReverseList(head.next);
    head.next.next = head;
    head.next = null;
    return tail;
}

// 1|* ->     2|*->      3|* ->    null
// prev       curr
//            prev       curr      curr.next
//                             
//                       prev      curr      
ListNode ReverseListLoop(ListNode head)
{
    ListNode prev = null;
    ListNode curr = head;
    while (curr != null)
    {
        ListNode nextTemp = curr.next;
        curr.next = prev;
        prev = curr;
        curr = nextTemp;
    }
    return prev;
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
// head  head.next   head.next.next   head.next.next.next 
//         ! 
//        head       head.next        head.next.next
// 1|* -> 2|*->      3|* ->           null
//                                    <-*|2
