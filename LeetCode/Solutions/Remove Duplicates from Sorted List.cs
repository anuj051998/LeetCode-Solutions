
using System.Collections.Generic;
using System.Linq;
public partial class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head is null)
        {
            return head;
        }

        IList<int> li = new List<int>();
        while (head is not null)
        {
            li.Add(head.val);
            head = head.next;
        }
        li = li.Distinct().Reverse().ToList();
        ListNode node = new ListNode()
        {
            val = li[0],
            next = null
        };
        if (li.Count > 1)
        {
            for (int i = 1; i < li.Count; i++)
            {
                ListNode temp = new ListNode()
                {
                    val = li[i],
                    next = node
                };
                node = temp;
            }
        }
        return node;
    }
}