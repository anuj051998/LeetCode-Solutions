using System;
using System.Collections.Generic;

public partial class Solution
{
    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        IList<string> result = new List<string>();
        string[] arrOne = new string[words1.Length];
        for(int i = 0;i< arrOne.Length; i++)
        {
            char[] tempArr = words1[i].ToCharArray();
            Array.Sort(tempArr);
            arrOne[i] = string.Join(string.Empty, tempArr);
        }
        return result;
    }
}