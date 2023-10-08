using NUnit.Framework;
using System.Collections.Generic;

namespace LeetcodeTests
{
    public partial class LeetCodeSolution
    {
        [TestRunner(Description = "Boats to require to save people")]
        public void BOATS_TO_SAVE_PEOPLE_TEST()
        {
            Solution solution = new Solution();
            var mockData = BOATS_TO_SAVE_PEOPLE_TEST_DATA();
            foreach (var item in mockData)
            {
                int res = solution.NumRescueBoats(item.Item1, item.Item2);
                Assert.AreEqual(item.Item3, res);
            }
        }



        /// <summary>
        /// Input test data
        /// </summary>
        /// <returns></returns>
        private IList<(int[], int, int)> BOATS_TO_SAVE_PEOPLE_TEST_DATA()
        {
            return new List<(int[], int, int)> {
                (
                    new int[]{ 5, 1, 4, 2 },6,2
                ),
                (
                    new int[] { 1,2 },
                    3,1
                ),
                (
                    new int[] { 3,2,2,1 },
                    3,3
                ),
                (
                new int[]{ 3,5,3,4}, 5,4
                )
            };
        }
    }
}
