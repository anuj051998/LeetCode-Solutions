public partial class Solution
{
    public int[] RunningSum(int[] nums)
    {
        double temp = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            temp += nums[i];
            nums[i] = (int)temp;
        }
        return nums;
    }
}