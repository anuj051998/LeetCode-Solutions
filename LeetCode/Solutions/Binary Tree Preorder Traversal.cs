
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
public partial class Solution {
    public static List<int> Traverse_PRE_ORDER(TreeNode node, List<int> li){
        if (node == null)
        {
            return new List<int>();
        }

        li.Add(node.val);
        Traverse_POST_ORDER(node.left, li);
        Traverse_POST_ORDER(node.right, li);
        return li;
    }
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> li = new List<int>();
        li = Traverse_PRE_ORDER(root, li);
        return li;
    }
}