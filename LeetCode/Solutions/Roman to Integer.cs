using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public int RomanToInt(string s)
    {
        IDictionary<string, int> di = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 },
            { "IV", 4 },
            { "IX", 9 },
            { "XL",40 },
            { "XC",90},
            {"CD",400 },
            { "CM",900}
        };

        int res = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            int temp = 0;
            if (i > 0)
            {
                temp = di.Where(x => x.Key.ToString() == $"{s[i - 1]}{s[i]}").Select(x => x.Value).FirstOrDefault();
                if (temp == 0)
                {
                    res += di.Where(x => x.Key.ToString() == $"{s[i]}").Select(x => x.Value).FirstOrDefault();
                }
                else
                {
                    res += temp;
                    --i;
                }
            }
            else
            {
                res += di.Where(x => x.Key.ToString() == $"{s[i]}").Select(x => x.Value).FirstOrDefault();
            }
        }
        return res;
    }
}