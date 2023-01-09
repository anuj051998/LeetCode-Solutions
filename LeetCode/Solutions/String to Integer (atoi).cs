public partial class Solution
{
    public int MyAtoi(string s)
    {
        s = s.TrimStart();
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        bool isNegative = s[0] == '-';
        double res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] is >= '0' and <= '9')
            {
                res = (res * 10) + int.Parse(s[i].ToString());
            }
            else
            {
                if (!"+-".Contains(s[i]) || i != 0)
                {
                    break;
                }
            }
        }
        int op;
        res = isNegative ? -res : res;
        op = res >= int.MaxValue ? int.MaxValue : res <= int.MinValue ? int.MinValue : (int)res;
        return op;
    }
}