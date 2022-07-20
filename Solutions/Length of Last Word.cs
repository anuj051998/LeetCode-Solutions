using System.Linq;

public partial class Solution
{
    public int LengthOfLastWord(string s) => s.Trim().Split(' ')[^1].Count();
}