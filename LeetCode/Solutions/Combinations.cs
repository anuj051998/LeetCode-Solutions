using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        IList<IList<int>> result = new List<IList<int>>();
     //   FindCombinatin(Enumerable.Range(1, n).ToArray(), 0, n, result);
        return result;
    }

    public void FindCombinatin(int[] arr, int start, int end, int k, IList<IList<int>> res)
    {
        if(end-start == k)
        {
            IList<int> resOne = new List<int>();
            for(int i = start; i < end; i++)
            {
                resOne.Add(arr[i]);
            }
            return;
        }
       //    FindCombinatin(arr, start + 1, )
    }
}