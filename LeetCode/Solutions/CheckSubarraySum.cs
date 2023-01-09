using System.Collections.Generic;

public partial class Solution
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        if (k == 0)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 0 && nums[i + 1] == 0)
                {
                    return true;
                }
            }
            return false;
        }
        IDictionary<int, int> sums = new Dictionary<int, int> { { 0, -1 } };
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            int mod = sum % k;
            if (sums.ContainsKey(mod) && i - sums[mod] > 1)
            {
                return true;
            }
            if (!sums.ContainsKey(mod))
            {
                sums[mod] = i;
            }
        }
        return false;
    }
}
