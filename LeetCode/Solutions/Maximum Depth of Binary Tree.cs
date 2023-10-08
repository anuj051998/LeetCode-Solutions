public class TreeNode
{
    public int val { get; set; }
    public TreeNode left { get; set; }
    public TreeNode right { get; set; }

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
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
            int lDepth = CheckDepth(node.left);
            int rDepth = CheckDepth(node.right);
            return lDepth > rDepth ? lDepth + 1 : rDepth + 1;
        }
    }
    public int MaxDepth(TreeNode root)
    {
        return CheckDepth(root);
    }
}