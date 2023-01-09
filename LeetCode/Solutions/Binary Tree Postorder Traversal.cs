using System.Collections.Generic;

public partial class Solution
{
    public static IList<int> Traverse_POST_ORDER(TreeNode node, IList<int> li)
    {
        if (node is null)
        {
            return new List<int>();
        }

        _ = Traverse_POST_ORDER(node.Left, li);
        _ = Traverse_POST_ORDER(node.Right, li);
        li.Add(node.Val);
        return li;
    }

    public IList<int> PostorderTraversal(TreeNode root)
    {
        return Traverse_POST_ORDER(root, new List<int>());
    }
}