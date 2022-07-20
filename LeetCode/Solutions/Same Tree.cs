
using System.Collections.Generic;
using System.Linq;
/**
* Definition for a binary tree node.
* public class TreeNode {
*     public int val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
*         this.val = val;
*         this.left = left;
*         this.right = right;
*     }
* }
*/
public partial class Solution
{
    public static List<int> GetItems(TreeNode node, List<int> li)
    {

        if (node == null)
        {
            li.Add(0);
            return new List<int>();
        }

        GetItems(node.left, li);
        GetItems(node.right, li);
        li.Add(node.val);
        return li;
    }

    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        List<int> li1 = GetItems(p, new List<int>());
        List<int> li2 = GetItems(q, new List<int>());
        return li1.Count() == li2.Count() && li1.SequenceEqual(li2);
    }
}