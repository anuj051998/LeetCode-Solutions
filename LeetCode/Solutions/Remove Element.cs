using System.Linq;

public partial class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        System.Collections.Generic.IList<int> li = nums.Where(x => x != val).Select(x => x).ToList();
        int index = 0;
        for (int i1 = 0; i1 < li.Count; i1++)
        {
            int i = li[i1];
            nums[index++] = i;
        }
        return li.Count;
    }
}