using System.Collections.Generic;

public partial class Solution
{
    public static IList<int> Traverse_POST_ORDER(TreeNode node, IList<int> li)
    {
        if (node is null)
        {
            return new List<int>();
        }

        _ = Traverse_POST_ORDER(node.left, li);
        _ = Traverse_POST_ORDER(node.right, li);
        li.Add(node.val);
        return li;
    }

    public IList<int> PostorderTraversal(TreeNode root)
    {
        return Traverse_POST_ORDER(root, new List<int>());
    }
}