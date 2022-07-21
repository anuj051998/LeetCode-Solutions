public partial class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int f = 0;
        int l = 1;
        int max = 0;

        if (s.Length == 1)
        {
            return 1;
        }

        while (f < s.Length && l < s.Length)
        {
            string sub = s[f..l];
            if (!sub.Contains(s[l]))
            {
                if (l == s.Length - 1)
                {
                    sub += s[l];
                    l++;
                }
                else
                {
                    l++;
                }
            }
            else
            {
                f++;
            }

            if (sub.Length > max)
            {
                max = sub.Length;
            }
        }
        return max;
    }
}
