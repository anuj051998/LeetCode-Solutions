using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public partial class Solution
    {
        private bool IsAnagram(string wordOne, string wordTwo)
        {
            char[] ArrayOne = wordOne.ToCharArray();
            char[] ArrayTwo = wordTwo.ToCharArray();
            Array.Sort(ArrayOne);
            Array.Sort(ArrayTwo);
            return ArrayOne.SequenceEqual(ArrayTwo);
        }

        public IList<string> RemoveAnagrams(string[] words)
        {
            IList<string> Words = words.ToList();
            IList<string> result = new List<string>();

            for (int i = 1; i < Words.Count(); i++)
            {
                string wordOne = Words[i];
                string wordTwo = Words[i - 1];
                if (IsAnagram(wordOne, wordTwo))
                {
                    Words.Remove(wordOne);
                    Words.Remove(wordTwo);
                    result.Add(wordTwo);
                }
                else
                {
                    Words.Remove(wordTwo);
                    result.Add(wordOne);
                }
            }

            return words;
        }
    }
}
