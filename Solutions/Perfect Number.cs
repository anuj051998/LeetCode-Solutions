using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public static List<int> GetDivisor(int num)
    {
        List<int> li = new List<int>();
        for (int i = 1; i <= (num / 2); i++)
        {
            if (num % i == 0)
                li.Add(i);
        }
        return li;
    }
    public bool CheckPerfectNumber(int num)
    {
        var op = GetDivisor(num);
        return num == op.Sum();
    }
}