using System.Collections.Generic;

public partial class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        int n = nums.Length;
        List<int> li = new List<int>();
        for (int i = 0; i < n; i++)
        {
            li.Insert(index[i], nums[i]);
        }
        return li.ToArray();
    }
}