public partial class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                switch (operations[i])
                {
                    case "X++":
                        x++;
                        break;
                    case "++X":
                        ++x;
                        break;
                    case "X--":
                        x--;
                        break;
                    case "--X":
                        --x;
                        break;
                }
            }
            return x;
    }
}