public partial class Solution
{
    public int StrStr(string haystack, string needle)
    {
        return haystack.Contains(needle) ? haystack.IndexOf(needle) : -1;
    }
}