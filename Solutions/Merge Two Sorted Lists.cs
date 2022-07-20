
using System.Collections.Generic;
using System.Linq;
/**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int val=0, ListNode next=null) {
*         this.val = val;
*         this.next = next;
*     }
* }
*/
public partial class Solution
{
    public static List<int> GetItemsForMergeTwoList(ListNode node)
    {
        List<int> li = new List<int>();
        while (node != null)
        {
            li.Add(node.val);
            node = node.next;
        }
        return li;
    }
    public ListNode MergeTwoLists_(ListNode list1, ListNode list2)
    {
        List<int> li = GetItemsForMergeTwoList(list1);
        li.AddRange(GetItemsForMergeTwoList(list2));
        li.Sort();
        if (!li.Any())
        {
            return list1;
        }

        ListNode node = new ListNode() { val = li[li.Count() - 1], next = null };
        for (int i = li.Count() - 2; i >= 0; i--)
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