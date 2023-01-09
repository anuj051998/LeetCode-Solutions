public partial class Solution
{
    public int AddDigits(int num)
    {
        int res = 0;
        while (num != 0)
        {
            res += num % 10;
            num /= 10;
            if (res > 9)
            {
                res = (res % 10) + (res / 10);
            }
        }
        return res;
    }
}