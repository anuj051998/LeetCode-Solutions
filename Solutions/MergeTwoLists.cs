using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public static List<int> GetItems(ListNode node)
    {
        List<int> li = new List<int>();
        while (node != null)
        {
            li.Add(node.val);
            node = node.next;
        }
        return li;
    }
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        List<int> li = GetItems(list1);
        li.AddRange(GetItems(list2));
        ListNode node = new ListNode() { val = li[0], next = null };
        for (int i = 1; i < li.Count(); i++)
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