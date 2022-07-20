using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IDictionary<string, IList<int>> di = new Dictionary<string, IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            di = TwoSum(nums, i, di);
        }
        return di.Values.ToList();
    }

    private static IDictionary<string, IList<int>> TwoSum(int[] nums, int i, IDictionary<string, IList<int>> data)
    {
        int low = i + 1, high = nums.Length - 1;
        while (low < high && high >= 0 && low < nums.Length && high > i)
        {
            int sum = nums[i] + nums[low] + nums[high];
            if (sum > 0)
            {
                high--;
            }
            else if (sum < 0)
            {
                low++;
            }
            else
            {
                IList<int> temp = new List<int>() { nums[i], nums[low], nums[high] };
                string key = string.Join("", temp);
                if (!data.ContainsKey(key))
                {
                    data.Add(key, temp);
                }
                low++;
            }
        }
        return data;
    }
}