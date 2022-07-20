using System;

public partial class Solution
{
    public int Reverse(int x)
    {
        long res = 0;
        while (x != 0)
        {
            res = res * 10 + x % 10;
            x /= 10;
        }
        return (int)(res > Int32.MaxValue || res < Int32.MinValue ? 0 : res);
    }
}