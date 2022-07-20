using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public partial class Solution
    {
        private IList<string> FindMatching(string[] arr)
        {
            string Key = arr[0];
            char[] arrOne = Key.ToCharArray();
            Array.Sort(arrOne);
            return arr.Where(x =>
            {
                if (x.Length == Key.Length)
                {
                    char[] tempArray = x.ToCharArray();
                    Array.Sort(tempArray);
                    return tempArray.SequenceEqual(arrOne);
                }
                else
                {
                    return false;
                }
            }).ToList();
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            while (strs.Length != 0)
            {
                IList<string> op = FindMatching(strs);
                strs = strs.Where(x => !op.Contains(x)).ToArray();
                result.Add(op);
            }
            return result;
        }
    }
}
