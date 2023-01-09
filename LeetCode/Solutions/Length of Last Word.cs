using System.Linq;

public partial class Solution
{
    public int LengthOfLastWord(string s)
    {
        return s.Trim().Split(' ')[^1].Count();
    }
}