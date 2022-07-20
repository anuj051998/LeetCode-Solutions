using System.Collections.Generic;

public partial class Solution
{
    public int[] PlusOne(int[] digits)
    {
        List<int> li = new List<int>();
        int carry = 0;
        for (int index = digits.Length - 1; index >= 0; index--)
        {
            int temp = digits[index];
            if (index == digits.Length - 1)
            {
                temp += 1;
            }
            if (carry + temp > 9)
            {
                li.Add((carry + temp) % 10);
                carry += temp / 10;
            }
            else
            {
                li.Add(temp + carry);
                carry = 0;
            }
        }
        if (carry != 0)
        {
            li.Add(carry);
        }

        li.Reverse();
        return li.ToArray();
    }
}