using System;

public partial class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] ans = new int[2];
        ans[0] = Array.IndexOf(nums, target);
        ans[1] = Array.LastIndexOf(nums, target);
        return ans;
    }
}