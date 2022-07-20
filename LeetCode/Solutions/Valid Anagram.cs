using System;

public partial class Solution
{
    public bool IsAnagram(string s, string t)
    {
        char[] s1 = s.ToCharArray();
        char[] s2 = t.ToCharArray();
        Array.Sort(s1);
        Array.Sort(s2);
        return string.Join("", s2) == string.Join("", s1);
    }
}