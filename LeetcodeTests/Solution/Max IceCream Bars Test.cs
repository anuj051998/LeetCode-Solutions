using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeTest
{
    public partial class LeetCodeSolution
    {
        [TestRunner]
        public void MAX_ICECREAM_BARS_Test()
        {
            IList<(int[], int, int)> mockData = MAX_ICECREAM_BARS_TestCaseMockData();

            Solution solution = new();
            foreach ((int[], int, int) data in mockData)
            {
                int res = solution.MaxIceCream(data.Item1, data.Item2);
                Assert.IsTrue(res == data.Item3);
            }
        }

        /// <summary>
        /// Input test data
        /// </summary>
        /// <returns></returns>
        private IList<(int[], int, int)> MAX_ICECREAM_BARS_TestCaseMockData()
        {
            return new List<(int[], int, int)> {
                (
                    new int[] { 7, 3, 3, 6, 6, 6, 10, 5, 9, 2 },
                    56,
                    9
                ),
                (
                    new int[] { 1,3,2,4,1 },
                    7,
                    4
                ),
                (
                    new int[] { 10,6,8,7,7,8 },
                    5,
                    0
                ),
                (
                    new int[] { 1,6,3,1,2,5 },
                    20,
                    6
                )
            };
        }
    }
}