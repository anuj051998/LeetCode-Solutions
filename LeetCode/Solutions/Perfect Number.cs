using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public static IList<int> GetDivisor(int num)
    {
        IList<int> li = new List<int>();
        for (int i = 1; i <= (num / 2); i++)
        {
            if (num % i == 0)
            {
                li.Add(i);
            }
        }
        return li;
    }
    public bool CheckPerfectNumber(int num)
    {
        IList<int> op = GetDivisor(num);
        return num == op.Sum();
    }
}