using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class Solution
{
    public string IntToRoman(int num)
    {
        IDictionary<char, int> dictionary = new Dictionary<char, int>
        {
            {'I', 1}, {'V', 5}, {'X', 10},
            {'L', 50}, {'C', 100},
            {'D', 500}, {'M', 1000},
            {'?', 5000}, {'*', 10000}
        };

        IList<int> ints = new List<int>();
        StringBuilder stringBuilder = new StringBuilder();
        for(int i= 0; i < 4; i++)
        {
            int digit = num % 10;
            num /= 10;
            ints.Add(digit);
        }
        for(int i = 3; i >= 0; --i)
        {
            // populateStr(stringBuilder, ints[i*2+2])
        }
        return string.Empty;
    }

    private void populateStr(StringBuilder ret, int digit, char tenChar, char fiveChar, char oneChar)
    {
        if (digit == 0) return;
        if (digit <= 3)
        {
            for (int i = 0; i < digit; ++i)
            {
                ret.Append(oneChar);
            }
            return;
        }
        if (digit == 4)
        {
            ret.Append(oneChar);
            ret.Append(fiveChar);
            return;
        }
        if (digit <= 8)
        {
            ret.Append(fiveChar);
            for (int i = 0; i < digit - 5; ++i)
{
                ret.Append(oneChar);
            }
            return;
        }
        if (digit == 9)
    {
            ret.Append(oneChar);
            ret.Append(tenChar);
            return;
        }
    }
}
