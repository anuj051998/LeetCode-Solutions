public partial class Solution
{
    public int SubtractProductAndSum(int n)
    {
        int sum = 0, product = 1;
        while (n != 0)
        {
            sum += n % 10;
            product *= n % 10;
            n /= 10;
        }
        return product - sum;
    }
}