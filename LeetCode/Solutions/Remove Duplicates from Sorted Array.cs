using System.Linq;

public partial class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int index = 0;
        int[] li = nums.Distinct().ToArray();
        for (int i1 = 0; i1 < li.Length; i1++)
        {
            int i = li[i1];
            nums[index++] = i;
        }
        return li.Length;
    }
}