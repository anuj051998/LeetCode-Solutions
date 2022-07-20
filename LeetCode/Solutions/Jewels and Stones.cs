using System.Linq;

public partial class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int total = 0;
        for (int i = 0; i < jewels.Length; i++)
        {
            total += stones.Where(x => x == jewels[i]).Count();
        }
        return total;
    }
}