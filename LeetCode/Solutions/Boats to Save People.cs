using System.Linq;

public partial class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        int sum = people.Sum();
        return sum % limit == 0 ? sum / limit : (sum / limit) + 1;
    }
}