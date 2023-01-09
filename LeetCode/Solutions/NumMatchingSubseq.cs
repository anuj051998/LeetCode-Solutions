
public partial class Solution
{
    public int NumMatchingSubseq(string s, string[] words)
    {
        int final = 0;

        for (int i = 0; i < words.Length; i++)
        {
            int a = 0;
            int b = 0;
            string current = words[i];
            while (b < current.Length && a < s.Length)
            {
                if (s[a] == current[b])
                {
                    a++;
                    b++;
                }
                else
                {
                    a++;
                }
            }
            if (b >= current.Length)
            {

                final++;
            }
        }
        return final;
    }
}
