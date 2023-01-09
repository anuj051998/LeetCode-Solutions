
using System.Collections.Generic;
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
    public static IList<int> Traverse_PRE_ORDER(TreeNode node, IList<int> li)
    {
        if (node is null)
        {
            return new List<int>();
        }

        li.Add(node.Val);
        _ = Traverse_POST_ORDER(node.Left, li);
        _ = Traverse_POST_ORDER(node.Right, li);
        return li;
    }
    public IList<int> PreorderTraversal(TreeNode root)
    {
        IList<int> li = new List<int>();
        li = Traverse_PRE_ORDER(root, li);
        return li;
    }
}