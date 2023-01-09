public class TreeNode
{
    public int Val { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        Val = val;
        Left = left;
        Right = right;
    }
}

public partial class Solution
{
    public static int CheckDepth(TreeNode node)
    {
        if (node is null)
        {
            return 0;
        }
        else
        {
            int lDepth = CheckDepth(node.Left);
            int rDepth = CheckDepth(node.Right);
            return lDepth > rDepth ? lDepth + 1 : rDepth + 1;
        }
    }
    public int MaxDepth(TreeNode root)
    {
        return CheckDepth(root);
    }
}