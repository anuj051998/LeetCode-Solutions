using System.Collections.Generic;

public partial class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>
        {
            new List<int>() // initially copying the empty list for first subset
        };
        for (int i = 0; i < nums.Length; i++)
        {
            int len = result.Count;
            for (int j = 0; j < len; j++)
            {
                List<int> temp = new List<int>();
                temp.AddRange(result[j]);
                temp.Add(nums[i]);
                result.Add(temp);
            }
        }
        return result;
    }
}