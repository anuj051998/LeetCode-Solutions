using System.Linq;

public partial class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var li = nums.Where(x => x != val).Select(x => x).ToList();
        int index = 0;
        foreach (int i in li)
        {
            nums[index++] = i;
        }
        return li.Count();
    }
}