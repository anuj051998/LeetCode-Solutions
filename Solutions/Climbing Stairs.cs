public partial class Solution
{
    static int Fibonacci(int n)
    {
        if (n < 2)
        {
            return n;
        }

        double start = 0, mid = 1, next = 0, index = 0;
        while (index++ < n)
        {
            next = start + mid;
            start = mid;
            mid = next;
        }
        return (int)next;
    }

    public int ClimbStairs(int n)
    {
        return Fibonacci(n);
    }
}