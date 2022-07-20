using System.Collections.Generic;

namespace LeetCode
{
    public partial class Solution
    {
        public int[] CombineArray(int[] arrOne, int[] arrTwo)
        {
            List<int> li = new List<int>();
            li.AddRange(arrOne);
            li.AddRange(arrTwo);
            li.Sort();
            return li.ToArray();
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] combinedArray = CombineArray(nums1, nums2);

            int mid = combinedArray.Length / 2;

            return combinedArray.Length % 2 == 0
                ? (double)(combinedArray[mid] + combinedArray[mid - 1]) / 2
                : combinedArray[mid];
        }
    }
}
