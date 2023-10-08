using System;
using System.Collections.Generic;

public partial class Solution
{
    public void Rotate(int[] nums, int k)
    {
        if (nums.Length <= 1)
        {
            return;
        }
        List<int> list = new List<int>();
        list.AddRange(nums);
        while (k-- != 0)
        {
            int index = list.Count - 1;
            int popedItem = list[index];
            list.RemoveAt(index);
            list.Insert(0,popedItem);
        }
        Array.Copy(list.ToArray(), nums, nums.Length);
    }
}