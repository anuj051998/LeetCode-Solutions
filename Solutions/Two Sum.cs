public partial class Solution
{
    public int[] TwoSum_(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { 0, 1 };
    }
}