using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    private IList<int> Traverse(ListNode node)
    {
        IList<int> li = new List<int>();
        while (node is not null)
        {
            li.Add(node.val);
            node = node.next;
        }
        return li;
    }
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0)
        {
            ListNode temp = null;
            return temp;
        }
        List<int> li = new();
        for (int i = 0; i < lists.Length; i++)
        {
            li.AddRange(Traverse(lists[i]));
        }
        if (!li.Any())
        {

            ListNode temp = null;
            return temp;
        }
        li.Sort();
        li.Reverse();
        ListNode node = new ListNode()
        {
            val = li[0],
            next = null
        };
        for (int i = 1; i < li.Count; i++)
        {
            ListNode tempNode = new ListNode()
            {
                val = li[i],
                next = node
            };
            node = tempNode;
        }
        return node;
    }
}