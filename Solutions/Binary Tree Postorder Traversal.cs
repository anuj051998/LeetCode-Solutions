using System.Collections.Generic;

public partial class Solution
{
    public static List<int> Traverse_POST_ORDER(TreeNode node, List<int> li)
    {
        if (node == null)
        {
            return new List<int>();
        }

        Traverse_POST_ORDER(node.left, li);
        Traverse_POST_ORDER(node.right, li);
        li.Add(node.val);
        return li;
    }

    public IList<int> PostorderTraversal(TreeNode root)
    {
        return Traverse_POST_ORDER(root, new List<int>());
    }
}