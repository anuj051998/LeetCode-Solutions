
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
    public static IList<int> GetItems(TreeNode node, IList<int> li)
    {

        if (node is null)
        {
            li.Add(0);
            return new List<int>();
        }

        _ = GetItems(node.Left, li);
        _ = GetItems(node.Right, li);
        li.Add(node.Val);
        return li;
    }

    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        IList<int> li1 = GetItems(p, new List<int>());
        IList<int> li2 = GetItems(q, new List<int>());
        return li1.Count == li2.Count && li1.SequenceEqual(li2);
    }
}