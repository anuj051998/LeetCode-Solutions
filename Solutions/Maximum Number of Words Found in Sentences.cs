using System.Linq;

public partial class Solution
{
    public int MostWordsFound(string[] sentences)
    {
        int max = 0;
        for (int i = 0; i < sentences.Length; i++)
        {
            int count = sentences[i].Split(' ').Count();
            if (count > max)
            {
                max = count;
            }
        }
        return max;
    }
}