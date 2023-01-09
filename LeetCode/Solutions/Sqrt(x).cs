using System;

public partial class Solution
{
    public int MySqrt(int x)
    {
        return x == 1 ? 1 : (int)Math.Pow(x, 0.5);
    }
}