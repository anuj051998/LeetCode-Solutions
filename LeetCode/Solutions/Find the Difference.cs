using System.Linq;

public partial class Solution
{
    public char FindTheDifference(string s, string t)
    {
        for (int i = 0; i < t.Length; i++)
        {
            char item = t[i];
            int count = t.Count(x => x == item);
            int countTwo = s.Count(x => x == item);
            if (count > countTwo)
            {
                return item;
            }
        }
        return ' ';
    }
}