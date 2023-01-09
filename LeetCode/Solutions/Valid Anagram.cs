using System;
using System.Linq;

public partial class Solution
{
    public bool IsAnagram(string s, string t)
    {
        char[] s1 = s.ToCharArray();
        char[] s2 = t.ToCharArray();
        Array.Sort(s1);
        Array.Sort(s2);
        return s1.SequenceEqual(s2);
    }
}