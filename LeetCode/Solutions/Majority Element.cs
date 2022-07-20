using System.Linq;

public partial class Solution {
    public int MajorityElement(int[] nums) {
        foreach(int item in nums.Distinct())
            {
                if (nums.Where(x => x == item).Count() > (nums.Count() / 2))
                    return item;
            }
            return 0;
    }
}