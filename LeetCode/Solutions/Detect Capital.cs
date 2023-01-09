using System.Linq;

public partial class Solution
{
    public bool DetectCapitalUse(string word)
    {
        int capitalCount = word.Count(x => x is >= 'A' and <= 'Z');
        return capitalCount == 0
            || (capitalCount == 1 && word[0] >= 'A' && word[0] <= 'Z')
            || capitalCount == word.Length;
    }
}
