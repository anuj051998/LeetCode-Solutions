using System;
using System.Collections.Generic;


public partial class Solution
{
    public string AddBinary(string a, string b)
    {
        int carry = 0;
        Stack<char> result = new Stack<char>();
        int i = a.Length - 1, j = b.Length - 1;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;
            if (i >= 0) sum += a[i--] - '0';
            if (j >= 0) sum += b[j--] - '0';

            result.Push((char)(sum % 2 + '0'));
            carry = sum / 2;
        }

        return new string(result.ToArray());
    }
}

