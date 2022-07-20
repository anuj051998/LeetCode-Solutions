using System.Collections.Generic;

public partial class Solution
{
    public static List<int> Traverse_InOrder(TreeNode node, List<int> li)
    {
        if (node == null)
            return new List<int>();
        Traverse_InOrder(node.left, li);
        li.Add(node.val);
        Traverse_InOrder(node.right, li);

        return li;
    }
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> li = new List<int>();
        li = Traverse_InOrder(root, li);
        return li;

    }
}