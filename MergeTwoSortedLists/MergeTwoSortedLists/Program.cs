namespace MergeTwoSortedLists;

class Program
{
    static void Main(string[] args)
    {
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4, new ListNode(9))));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(5, new ListNode(6,  new ListNode(7)))));

        var mergedList = Solution.MergeTwoLists(list1, list2);

        while (mergedList != null)
        {
            Console.Write($"{mergedList.val} ");
            mergedList = mergedList.next;
        }
    }
}

public class Solution
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var attachmentNode = new ListNode();
        var currentNode = attachmentNode;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                currentNode.next = list1;
                list1 = list1.next;
            }
            else if (list1.val >= list2.val)
            {
                currentNode.next = list2;
                list2 = list2.next;
            }
            
            currentNode = currentNode.next;
        }

        if (list1 != null) currentNode.next = list1;
        if (list2 != null) currentNode.next = list2;

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