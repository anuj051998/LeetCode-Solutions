using System.Linq;
public partial class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        int coultResult = 0;
        for (int i = 0; i < strs[0].Length; i++)
        {
            char[] res = strs.Select(x => x[i]).ToArray();
            for (int j = 0; j < res.Length - 1; j++)
            {
                if (res[j] > res[j + 1])
                {
                    coultResult++;
                    break;
                }
            }
        }
        return coultResult;
    }
}