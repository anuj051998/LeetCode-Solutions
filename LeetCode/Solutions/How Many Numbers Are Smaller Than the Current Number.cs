using System.Linq;

public partial class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int n = nums.Length;
        int[] ans = new int[n];
        for (int i = 0; i < n; i++)
        {
            ans[i] = nums.Count(x => x < nums[i]);
        }
        return ans;
    }
}