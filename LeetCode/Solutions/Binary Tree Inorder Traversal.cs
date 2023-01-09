using System.Collections.Generic;

public partial class Solution
{
    public static IList<int> Traverse_InOrder(TreeNode node, IList<int> li)
    {
        if (node == null)
        {
            return new List<int>();
        }

        _ = Traverse_InOrder(node.Left, li);
        li.Add(node.Val);
        _ = Traverse_InOrder(node.Right, li);
        return li;
    }
    public IList<int> InorderTraversal(TreeNode root)
    {
        IList<int> li = new List<int>();
        li = Traverse_InOrder(root, li);
        return li;
    }
}