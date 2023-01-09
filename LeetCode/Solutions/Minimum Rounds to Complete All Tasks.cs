using System;

public partial class Solution
{
    public int MinimumRounds(int[] tasks)
    {
        Array.Sort(tasks);
        int steps = 0;
        for (int i = 0; i < tasks.Length; i++)
        {
            int count = 1;
            while (i < tasks.Length - 1 && tasks[i] == tasks[i + 1])
            {
                count++;
                i++;
            }
            if (count == 1)
            {
                return -1;
            }
            while (count != 0)
            {
                if (count % 3 is > 2 or 0)
                {
                    steps++;
                    count -= 3;
                }
                else
                {
                    steps++;
                    count -= 2;
                }
            }
        }

        return steps;
    }
}