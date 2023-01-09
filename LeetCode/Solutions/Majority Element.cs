using System.Linq;

public partial class Solution
{
    public int MajorityElement(int[] nums)
    {
        foreach (int item in nums.Distinct())
        {
            if (nums.Count(x => x == item) > (nums.Length / 2))
            {
                return item;
            }
        }
        return 0;
    }
}