using System.Collections.Generic;
using System.Linq;

public partial class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        IList<bool> li = new List<bool>();
        int max = candies.Max();
        for(int count = 0; count < candies.Length; count++){
            if(candies[count] + extraCandies >= max){
                li.Add(true);
            }
            else{
                li.Add(false);
            }
        }
        return li;
    }
}