using System.Collections;
using System.Collections.Generic;
using System.Text;

public partial class Solution
{
    public string IntToRoman(int num)
    {
        StringBuilder result = new StringBuilder();

        IDictionary<int, string> di = new Dictionary<int, string>()
            {{1,"I"},
            {4,"IV"},
            {5,"V"},
            {9,"IX"},
            {10,"X"},
            {40,"XL"},
            {50,"L"},
            {90,"XC"},
            {100,"C"},
            {400,"CD"},
            {500,"D"},
            {900,"CM"},
            {1000,"M"},
            };

        IList<int> divider = new List<int>(di.Keys);
        int lastUpBound = divider.Count - 1;

        while (num > 0)
        {
            for (int i = lastUpBound; i >= 0; i--)
            {
                if (num / divider[i] > 0)
                {
                    for (int j = 1; j <= num / divider[i]; j++)
                    {
                        result.Append(di[divider[i]]);
                    }
                    num -= (num / divider[i]) * divider[i];
                    lastUpBound--;
                }
            }
        }
        return result.ToString();
    }
}