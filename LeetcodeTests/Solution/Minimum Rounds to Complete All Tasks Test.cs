using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeTest
{
    public partial class LeetCodeSolution
    {
        [Test]
        public void Minimum_Rounds_Complete_All_Tasks_Test()
        {
            IList<(int[], int)> mockData = TestCaseMockData();

            Solution solution = new();
            foreach ((int[], int) data in mockData)
            {
                int res = solution.MinimumRounds(data.Item1);
                Assert.IsTrue(res == data.Item2);
            }
        }

        /// <summary>
        /// Input test data
        /// </summary>
        /// <returns></returns>
        private IList<(int[], int)> TestCaseMockData()
        {
            return new List<(int[], int)> {
                (
                    new int[] { 66, 66, 63, 61, 63, 63, 64, 66, 66, 65, 66, 65, 61, 67, 68, 66, 62, 67, 61, 64, 66, 60, 69, 66, 65, 68, 63, 60, 67, 62, 68, 60, 66, 64, 60, 60, 60, 62, 66, 64, 63, 65, 60, 69, 63, 68, 68, 69, 68, 61 },
                    20
                ),
                (
                    new int[] { 2, 2, 3, 3, 2, 4, 4, 4, 4, 4 },
                    4
                ),
                (
                    new int[] { 2,3,4 },
                    -1
                ),(
                new int[] { 5, 5, 5, 5 },
                2
                ),
                (
                new int[]{ 69,65,62,64,70,68,69,67,60,65,69,62,65,65,61,66,68,61,65,63,60,66,68,66,67,65,63,65,70,69,70,62,68,70,60,68,65,61,64,65,63,62,62,62,67,62,62,61,66,69},
                20)
            };
        }
    }
}