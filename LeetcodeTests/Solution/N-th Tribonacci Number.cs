using LeetcodeTests;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeTest
{
    public partial class LeetCodeSolution
    {
        [Theory]
        public void TestNthTribonacciSeries()
        {
            foreach (var item in GetMockDataForTribonacci())
            {
                Solution solution = new Solution();
                Assert.AreEqual(item.Output, solution.Tribonacci(item.Input));
            }
        }

        private IList<MockData<int, int>> GetMockDataForTribonacci()
        {
            return new List<MockData<int, int>>()
            {
                new MockData<int, int> { Input = 4, Output = 4 },
                new MockData<int, int> { Input = 1, Output = 1 }
            };
        }
    }
}