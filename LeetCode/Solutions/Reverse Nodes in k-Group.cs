using System.Collections.Generic;

public partial class Solution
{
    private IList<int> GetListNodeItems(ListNode node)
    {
        List<int> res = new List<int>();
        while (node != null)
        {
            res.Add(node.val);
            node = node.next;
        }
        return res;
    }
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        IList<int> items = GetListNodeItems(head);
        int iterations = items.Count / k;

        for(int iteration = 1; iteration <= iterations; iteration++)
        {
            IList<int> reverseItems = new List<int>();
            for(int index = k * iteration - 1; index >= k*(iteration-1); index--)
            {
                reverseItems.Add(items[index]);
            }

            for (int index = 0; index < reverseItems.Count; index++)
            {
                int findIndex = k * iteration - index;
                items[findIndex - 1] = reverseItems[k-index-1];
            }
        }


        ListNode listNode = new ListNode { val = items[^1], next = null };
        for(int i = items.Count-2; i > -1; i--)
        {
            ListNode tempNode = new ListNode { val = items[i], next = listNode };
            listNode = tempNode;
        }
        return listNode;
    }
}

