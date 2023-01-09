using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeTest
{
    public partial class LeetCodeSolution
    {
        [Test]
        public void SQRT_X_TEST()
        {
            IList<(int, int)> mockData = SQRT_X_TEST_MOCK_DATA();

            Solution solution = new();
            foreach ((int, int) data in mockData)
            {
                int res = solution.MySqrt(data.Item1);
                Assert.IsTrue(res == data.Item2);
            }
        }

        /// <summary>
        /// Input test data
        /// </summary>
        /// <returns></returns>
        private IList<(int, int)> SQRT_X_TEST_MOCK_DATA()
        {
            return new List<(int, int)> {
                (8,2),
                (9,3)
            };
        }
    }
}