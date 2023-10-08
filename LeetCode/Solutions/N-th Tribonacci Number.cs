public partial class Solution
{
    public int Tribonacci(int n)
    {
        if (n <= 2)
        {
            return n;
        }
        return FindTribonacci(0, 1, n, 0);
    }

    private int FindTribonacci(int start, int next,int n, int sum)
    {
        if(n <= 2)
        {
            return sum;
        }
        sum += next + start;
        sum = FindTribonacci(next, start + next, --n, sum);
        return sum;
    }
}