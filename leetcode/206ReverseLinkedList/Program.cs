// Input: head = [1,2,3,4,5]
// Output: [5,4,3,2,1]

var head = new ListNode(1, new ListNode(2, new ListNode(3))); // new ListNode(4, new ListNode(5))
var s=new ListNode(0);
var reversedHead = ReverseList(head, ref s);
while (reversedHead.next != null)
{
    Console.Write(reversedHead + "->");
}

Console.ReadLine();

ListNode ReverseList(ListNode head, ref ListNode tail)
{
    if (head != null && head.next == null)
    {
        tail = new ListNode(head.val);
        return tail;
    }
    var secondNode = ReverseList(head.next, ref tail);
    secondNode.next = new ListNode(head.val);
    // swap
    return tail; //head 2, newHead 3
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

// 1|* -> 2|* -> 3|* -> null
// St1) 1|* -> 2|*
// st2) 2|* -> 3|* secondNode = 3|*
// st3) 3|* -> null

// st 1) 5|* -> null return null
// st 2) 4|* -> 5
// if(head==null || head.next == null) return head;
// firstNode = head
//                head 4, head.next 5
// swap
// // secondNode = f(head.next) // st 1) return 5; firstNode = head; secondNode.next = firstNode;
// secondNode.next = firstNode;
//return secondNode
// f(head)= 