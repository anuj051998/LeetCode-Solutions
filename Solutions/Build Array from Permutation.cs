public partial class Solution
{
    public int[] BuildArray(int[] nums)
    {
        int len = nums.Length;
        int[] ans = new int[len];
        for (int i = 0; i < len; i++)
        {
            ans[i] = nums[nums[i]];
        }
        return ans;
    }
}