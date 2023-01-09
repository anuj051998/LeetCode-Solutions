using System.Linq;

public partial class Solution
{
    public int SingleNumber(int[] nums)
    {
        foreach (int i in nums)
        {
            if (nums.Count(x => x == i) == 1)
            {
                return i;
            }
        }
        return 0;
    }
}