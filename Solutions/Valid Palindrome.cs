using System.Text;

public partial class Solution
{
    public static string Clean(string s)
    {
        StringBuilder op = new StringBuilder();
        s = s.ToLower();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'a' && s[i] <= 'z' || s[i] >= '0' && s[i] <= '9')
            {
                op.Append(s[i]);
            }
        }
        return op.ToString();
    }
    public bool IsPalindrome(string s)
    {
        s = Clean(s);
        if (s.Length <= 1)
        {
            return true;
        }
        for (int i = 0, j = s.Length - 1; i < j; i++, j--)
        {
            if (s[i] != s[j])
            {
                return false;
            }
        }
        return true;
    }
}