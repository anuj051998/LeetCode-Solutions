using System;

namespace LeetCode
{
    public partial class Solution
    {
        public int MaxArea(int[] height)
        {
            int maxSize = 0;
            for (int i = 0, j = height.Length - 1; i < j;)
            {
                int HeightOne = height[i];
                int HeightTwo = height[j];
                int min = Math.Min(HeightOne, HeightTwo);

                int Size = min * (j - i);
                if (maxSize < Size)
                {
                    maxSize = Size;
                }
                if (HeightOne > HeightTwo)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return maxSize;
        }
    }
}
