using System;
using System.Collections.Generic;
using System.Linq;


public partial class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IDictionary<string, IList<string>> groups = new Dictionary<string, IList<string>>();
        foreach (string s in strs)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string key = new(chars);
            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }
            groups[key].Add(s);
        }
        return groups.Values.ToList();
    }
}
