public partial class Solution
{
    public int MaxIceCream(int[] costs, int coins)
    {
        System.Array.Sort(costs);
        int count = 0;
        if (costs[0] > coins)
        {
            return count;
        }
        int index = 0;
        while (coins != 0 && index < costs.Length)
        {
            if (coins >= costs[index])
            {
                coins -= costs[index];
                count++;
            }
            else
            {
                break;
            }
            index++;
        }
        return count;
    }
}