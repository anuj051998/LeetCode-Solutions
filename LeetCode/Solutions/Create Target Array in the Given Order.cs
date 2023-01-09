using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        int n = nums.Length;
        IList<int> li = new List<int>();
        for (int i = 0; i < n; i++)
        {
            li.Insert(index[i], nums[i]);
        }
        return li.ToArray();
    }
}