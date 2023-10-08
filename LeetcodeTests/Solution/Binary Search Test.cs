using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeTest
{
    public partial class LeetCodeSolution
    {
        [Test]
        public void BINARY_SEARCH_TEST()
        {
            //IList<(int[], int, int)> mockData = BINARY_SEARCH_TEST_MOCK_DATA();

            //Solution solution = new();
            //foreach ((int[], int, int) data in mockData)
            //{
            //    int res = solution.Search(data.Item1, data.Item2);
            //    Assert.IsTrue(res == data.Item3);
            //}

            var li = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            var li2 = li[1..^0];
        }

        /// <summary>
        /// Input test data
        /// </summary>
        /// <returns></returns>
        private IList<(int[], int, int)> BINARY_SEARCH_TEST_MOCK_DATA()
        {
            return new List<(int[], int, int)> {
                (
                    new int[] { 1,2,3,4,5,6,7,8,9 },
                    6,
                    5
                ),
                (
                    new int[] { 1,2,3,4,5,6,7,8,9 },
                    9,
                    8
                ),
            };
        }
    }
}