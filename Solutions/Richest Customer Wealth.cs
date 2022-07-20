using System.Linq;

public partial class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int max = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            if (accounts[i].Sum() > max)
            {
                max = accounts[i].Sum();
            }
        }
        return max;
    }
}