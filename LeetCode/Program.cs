using LeetCode.Solutions;
using System;

namespace LeetCode
{
    internal class Program
    {
        protected Program() { }

        private static void Main()
        {
            Ms1 sol = new Ms1();
            Console.WriteLine(sol.solution(new int[] { 8, 8, 8, 7, 7, 7, 7, 7, 7, -8 }, 1)); // Expected: 1
            Console.WriteLine(sol.solution(new int[] { -5, 1, 1, 1, 4, 4, 4, 4, 7, 6 }, 6)); // Expected: 7
            Console.WriteLine(sol.solution(new int[] { -7, -6, -3, -2, -2, -2, -2, -2, -2, -1 }, 5)); // Expected: 3
            Console.WriteLine(sol.solution(new int[] { 6, 6, 6, 6, 6, 6 }, 3)); // Expected: 1
            Console.ReadKey();
        }
    }
}
