using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeTest
{
    public partial class LeetCodeSolution
    {
        [Test]
        public void VALID_ANAGRAM_TEST()
        {
            IList<(string, string, bool)> mockData = VALID_ANAGRAM_TEST_MOCK_DATA();

            Solution solution = new();
            foreach ((string, string, bool) data in mockData)
            {
                bool res = solution.IsAnagram(data.Item1, data.Item2);
                Assert.IsTrue(res == data.Item3);
            }
        }

        /// <summary>
        /// Input test data
        /// </summary>
        /// <returns></returns>
        private IList<(string, string, bool)> VALID_ANAGRAM_TEST_MOCK_DATA()
        {
            return new List<(string, string, bool)> {
                ("XYZ", "ZYX", true),
                ("ABCD", "CDBAA", false),
            };
        }
    }
}