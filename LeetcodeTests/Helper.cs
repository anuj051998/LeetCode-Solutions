using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeTests
{
    internal static class Helper
    {
        public static ListNode FormListNode(this IEnumerable<int> items)
        {
            if (items == null)
            {
                return null;
            }
            items = items.Reverse();
            ListNode listNode = new ListNode(items.First());
            for(int i=1; i < items.Count(); i++) 
            {
                ListNode newNode = new ListNode(items.ElementAt(i));
                newNode.next = listNode;
                listNode = newNode;
            }
            return listNode;
        }
        public static int[] FormArray(this ListNode head)
        {
           IList<int> list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            return list.ToArray();
        }
    }
}
