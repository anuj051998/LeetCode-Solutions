using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        IDictionary<string, IList<int>> di = new Dictionary<string, IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                di = TwoSum(nums, i, j, di, target);
            }
        }
        return di.Values.ToList();
    }

    private static IDictionary<string, IList<int>> TwoSum(int[] nums, int i, int j, IDictionary<string, IList<int>> data, int target)
    {
        int low = j + 1, high = nums.Length - 1;

        while (low < high && high >= 0 && low < nums.Length && high > i)
        {
            int sum = nums[i] + nums[low] + nums[high] + nums[j];
            if (sum > target)
            {
                high--;
            }
            else if (sum < target)
            {
                low++;
            }
            else
            {
                IList<int> temp = new List<int>() { nums[i], nums[low], nums[high], nums[j] };
                string key = string.Join("", temp);
                bool res = data.ContainsKey(key);
                if (!res)
                {
                    data.Add(key, temp);
                }
                low++;
            }
        }
        return data;
    }
}