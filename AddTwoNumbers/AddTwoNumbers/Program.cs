namespace AddTwoNumbers;

class Program
{
    static void Main(string[] args)
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        var summedList = Solution.AddTwoNumbers(l1, l2);

        while (summedList != null)
        {
            Console.Write($"{summedList.val} ");
            summedList = summedList.next;
        }
    }
}

public class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var attachmentNode = new ListNode();
        var currentNode = attachmentNode;

        var carryOver = 0;

        while (l1 != null || l2 != null)
        {
            int nodeValue1 = (l1 != null) ? l1.val : 0;
            int nodeValue2 = (l2 != null) ? l2.val : 0;

            int nodeValueSum = nodeValue1 + nodeValue2 + carryOver;
            carryOver = nodeValueSum / 10;

            currentNode.next = new ListNode(nodeValueSum % 10);
            currentNode = currentNode.next;

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }

        if (carryOver > 0) currentNode.next = new ListNode(carryOver);

        return attachmentNode.next;
    }
}

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