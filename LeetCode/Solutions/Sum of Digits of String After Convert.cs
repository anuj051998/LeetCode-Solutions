using System;
using System.Text;

public partial class Solution
{
    public static string ConvertInt(string s)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            _ = builder.Append(s[i] - 96);
        }
        return builder.ToString();
    }

    public int GetLucky(string s, int k)
    {
        string res = ConvertInt(s);
        for (int i = 0; i < k; i++)
        {
            long sum = 0;
            for (int item = 0; item < res.Length; item++)
            {
                sum += int.Parse(res[item].ToString());
            }
            res = sum.ToString();
        }
        return Convert.ToInt32(res);
    }
}