
using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    private List<int> GetListNodeItem(ListNode node)
    {
        List<int> res = new List<int>();
        while (node != null)
        {
            res.Add(node.val);
            node = node.next;
        }
        return res;
    }

    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        List<int> items = GetListNodeItem(head);
        IList<int> reverse = new List<int>();
        for (int i = right - 1; i >= left - 1; i--)
        {
            reverse.Add(items[i]);
        }
        int index = 0;

        for (int i = left - 1; i < right; i++)
        {
            items[i] = reverse[index];
            index++;
        }
        ListNode node = new ListNode() { val = items[^1], next = null };
        for (int i = items.Count - 2; i >= 0; i--)
        {
            ListNode listNode = new ListNode { val = items[i], next = node };
            node = listNode;
        }
        return node;
    }
}
