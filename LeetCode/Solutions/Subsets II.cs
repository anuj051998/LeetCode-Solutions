using System.Collections.Generic;

public partial class Solution
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        IDictionary<string, IList<int>> di = new Dictionary<string, IList<int>>();
        result.Add(new List<int>()); // initially copying the empty list for first subset
        for (int i = 0; i < nums.Length; i++)
        {
            int len = result.Count;
            for (int j = 0; j < len; j++)
            {
                List<int> temp = new List<int>();
                temp.AddRange(result[j]);
                temp.Add(nums[i]);
                temp.Sort();
                string str = string.Join(",", temp);
                if (!di.ContainsKey(str))
                {
                    result.Add(temp);
                    di.Add(str, temp);
                }
            }
        }
        return result;
    }

}