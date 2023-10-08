using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(candidates);
        // step 1: find out all candidate who is alone enough to sum upto target
        for(int i = 0; i < candidates.Length; i++)
        {
            if(target > candidates[i])
            {
                break;
            }
            if (target % candidates[i] == 0)
            {
                int cnt = target / candidates[i];
                result.Add(Enumerable.Range(0, cnt).Select(x => candidates[i]).ToList());
            }
        }

        return result;
    }
}