public partial class Solution
{
    public double MyPow(double x, int n)
    {
        if (n == 0)
        {
            return 1;
        }

        double temp;

        temp = MyPow(x, n / 2);

        return n % 2 == 0 ? temp * temp : n > 0 ? x * temp * temp : temp * temp / x;
    }
}