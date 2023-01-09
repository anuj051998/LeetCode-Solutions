public partial class Solution
{
    public int Fib(int n)
    {
        return n <= 1 ? n : Fib(n - 1) + Fib(n - 2);
    }
}