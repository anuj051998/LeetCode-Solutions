using System;

public partial class Solution
{
    public int MySqrt(int x)
    {
        if (x == 1)
            return 1;
        return (int)(Math.Pow(x, 0.5));
    }
}