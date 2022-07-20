
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
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
        {
            return head;
        }

        List<int> li = new List<int>();
        while (head != null)
        {
            li.Add(head.val);
            head = head.next;
        }
        li = li.Distinct().Reverse().ToList();
        ListNode node = new ListNode() { val = li[0], next = null };
        if (li.Count() > 1)
        {


            for (int i = 1; i < li.Count(); i++)
            {
                ListNode temp = new ListNode
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