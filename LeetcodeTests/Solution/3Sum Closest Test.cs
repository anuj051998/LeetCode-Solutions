using LeetcodeTests;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetcodeTest
{
    public partial class LeetCodeSolution
    {
        [Theory]
        public void Test3SumClosest()
        {
            Solution solution = new Solution();
            foreach (var data in GetMockData()) {
                int res = solution.ThreeSumClosest(data.Input1, data.Input2);
                Assert.AreEqual(data.Output, res);
            }
        }

        private IList<MockData<int[], int, int>> GetMockData()
        {
            return
                new List<MockData<int[], int, int>>()
                {
                    new MockData<int[], int, int>
                    {
                        Input1 = new int[] { -1, 2, 1, -4 },
                        Input2 = 1,
                        Output = 2
                    }
                };
        }
    }
}
