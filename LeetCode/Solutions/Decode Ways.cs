
public partial class Solution
{
    public int NumDecodings(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int num = int.Parse(s[i].ToString());
            if (num > 1 && num < 3 && i < s.Length - 1)
            {
                count++;
            }
            count++;
        }
        return count;
    }
}

