
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
    public ListNode ReverseList(ListNode head)
    {
        List<int> li = new();
        while (head is not null)
        {
            li.Add(head.val);
            head = head.next;
        }
        if (!li.Any())
        {
            return head;
        }

        ListNode tempNode = new ListNode()
        {
            val = li[0],
            next = null
        };
        for (int i = 1; i < li.Count; i++)
        {
            ListNode temp = new ListNode()
            {
                val = li[i],
                next = tempNode
            };
            tempNode = temp;
        }
        return tempNode;
    }
}