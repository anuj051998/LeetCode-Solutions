using System.Linq;

public partial class Solution
{
    public char FindTheDifference(string s, string t)
    {
        foreach (char item in t)
        {
            int count = t.Where(x => x == item).Count();
            int countTwo = s.Where(x => x == item).Count();
            if (count > countTwo)
                return item;
        }
        return ' ';
    }
}