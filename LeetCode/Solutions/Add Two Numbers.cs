using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public static int[] GetItem(ListNode node)
    {
        IList<int> li = new List<int>();
        while (node is not null)
        {
            li.Add(node.val);
            node = node.next;
        }
        return li.ToArray();
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int[] arr1 = GetItem(l1);
        int[] arr2 = GetItem(l2);
        Array.Reverse(arr1);
        Array.Reverse(arr2);
        int carry = 0, lenOne = arr1.Length, lenTwo = arr2.Length;
        IList<int> res = new List<int>();
        for (int indexOne = lenOne - 1, indexTwo = lenTwo - 1; indexOne >= 0 || indexTwo >= 0; indexOne--, indexTwo--)
        {
            int sum = carry;
            sum += indexOne >= 0 ? arr1[indexOne] : 0;
            sum += indexTwo >= 0 ? arr2[indexTwo] : 0;
            if (sum > 9)
            {
                res.Add(sum % 10);
                carry = sum / 10;
            }
            else
            {
                res.Add(sum);
                carry = 0;
            }
        }
        if (carry != 0)
        {
            res.Add(carry);
        }

        _ = res.Reverse();
        ListNode li = new ListNode()
        {
            val = res[0],
            next = null
        };
        for (int i = 1; i < res.Count; i++)
        {
            ListNode tempNode = new ListNode()
            {
                val = res[i],
                next = li
            };
            li = tempNode;

        }
        return li;
    }
}