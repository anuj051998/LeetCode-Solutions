using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    private static int[] GetNumbers(int num)
    {
        IList<int> li = new List<int>();
        while (num != 0)
        {
            li.Add(num % 10);
            num /= 10;
        }
        return li.ToArray();
    }
    private static bool IsSelfDivideNumber(int num)
    {
        int[] nums = GetNumbers(num);
        if (nums.Contains(0))
        {
            return false;
        }
        foreach (int item in nums)
        {
            if (num % item != 0)
            {
                return false;
            }
        }
        return true;
    }
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        IList<int> li = new List<int>();
        for (int i = left; i <= right; i++)
        {
            if (IsSelfDivideNumber(i))
            {
                li.Add(i);
            }
        }
        return li;
    }
}