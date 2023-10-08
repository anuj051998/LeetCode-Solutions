using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public partial class Solution
{
    public bool IsStringPalindrome(string s)
    {
        int startIndex = 0, endIndex = s.Length - 1;
        while (startIndex < endIndex)
        {
            if (s[startIndex++] != s[endIndex--])
            {
                return false;
            }
        }
        return true;
    }
    public string LongestPalindrome(string s)
    {
        IDictionary<char, IList<int>> di = new Dictionary<char, IList<int>>();
        string res = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            if (!di.ContainsKey(s[i]))
            {
                di.Add(s[i], new List<int> { i });
            }
            else
            {
                di[s[i]].Add(i);
                for (int index = 0; index < di[s[i]].Count; index++)
                {
                    //int len = di[s[i]].Count;
                    //string word = string.Join(string.Empty, di[s[i]].);
                    //if (IsStringPalindrome(word) && res.Length < word.Length)
                    //{
                    //    res = s.Substring(di[s[i]][index], i - di[s[i]][index] + 1);
                    //}
                    continue;
                }
            }
        }
        return string.IsNullOrEmpty(res) ? s[0].ToString() : res;
    }

}