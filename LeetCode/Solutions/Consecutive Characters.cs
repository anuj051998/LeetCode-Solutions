using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public int MaxPower(string s)
    {
        IList<int> li = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            int count = 0;
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            i += count;
            li.Add(count);
        }
        return li.Max() + 1;
    }
}