public partial class Solution
{
    public bool IsMatch(string s, string p)
    {
        if (p.Length == 0)
        {
            return s.Length == 0;
        }

        bool first_match = (s.Length != 0) && (p[0] == s[0] || p[0] == '.');

        return p.Length >= 2 && p[1] == '*'
            ? IsMatch(s, p[2..]) || (first_match && IsMatch(s[1..], p))
            : first_match && IsMatch(s[1..], p[1..]);
    }
}
