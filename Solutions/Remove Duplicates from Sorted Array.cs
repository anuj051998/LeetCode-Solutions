using System.Linq;

public partial class Solution {
    public int RemoveDuplicates(int[] nums) {
        int index = 0;
            var li = nums.Distinct().ToArray();
            foreach (var i in li)
            {
                nums[index++] = i;
            }
            return li.Count();
    }
}