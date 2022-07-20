public partial class Solution {
    public int MyAtoi(string s) {
        s = s.TrimStart();
            if (string.IsNullOrEmpty(s))
                return 0;
            bool isNegative = s[0] == '-';
            double res = 0;
            for (int i= 0; i < s.Length; i++)
            {
                if(s[i] >= '0' && s[i] <= '9')
                {
                    res = res * 10 + int.Parse(s[i].ToString());
                }
                else
                {
                    if (!"+-".Contains(s[i]) || i!=0)
                    {
                        break;
                    }
                }
            }
            int op;
            res = isNegative ? -res : res;
            if(res >= int.MaxValue)
            {
                op = int.MaxValue;
            }
            else
                if (res <= int.MinValue)
                {
                    op = int.MinValue;
                }
            else
            {
                op = (int)res;
            }
            return op;
    }
}