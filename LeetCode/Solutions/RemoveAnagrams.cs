using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public IList<string> RemoveAnagrams(string[] words)
    {
        IList<string> Words = words.ToList();
        IList<string> result = new List<string>();

        for (int i = 1; i < Words.Count; i++)
        {
            string wordOne = Words[i];
            string wordTwo = Words[i - 1];
            if (IsAnagram(wordOne, wordTwo))
            {
                _ = Words.Remove(wordOne);
                _ = Words.Remove(wordTwo);
                result.Add(wordTwo);
            }
            else
            {
                _ = Words.Remove(wordTwo);
                result.Add(wordOne);
            }
        }

        return words;
    }
}

