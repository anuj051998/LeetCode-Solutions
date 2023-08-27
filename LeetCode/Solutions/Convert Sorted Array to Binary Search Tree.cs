using System.Linq;

public partial class Solution
{
  
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length == 0)
        {
            return null;
        }
        if (nums.Length == 1)
        {
            return new TreeNode(nums[0], null, null);
        }
        int mid = nums.Length / 2;
        return new TreeNode(
            nums[mid],
            SortedArrayToBST(nums.Take(mid).ToArray()),
            SortedArrayToBST(nums.Skip(mid + 1).ToArray())
        );
    }
}