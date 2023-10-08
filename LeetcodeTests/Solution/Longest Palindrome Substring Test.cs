using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeTest
{
    public partial class LeetCodeSolution
    {
        [Test]
        public void LONGEST_PALINDROME_SUB_STR_TEST()
        {
            IList<(string, string, string)> mockData = LONGEST_PALINDROME_SUB_STR_TestCaseMockData();

            Solution solution = new Solution();
            foreach ((string, string, string) data in mockData)
            {
                string res = solution.LongestPalindrome(data.Item1);
                Assert.IsTrue(res == data.Item3 || res == data.Item2);
            }
        }

        /// <summary>
        /// Input test data
        /// </summary>
        /// <returns></returns>
        private IList<(string, string, string)> LONGEST_PALINDROME_SUB_STR_TestCaseMockData()
        {
            return new List<(string, string, string)> {
                (
                    "aacabdkacaa", "aca", "aca"
                ),
                (
                    "a",
                    "a", "a"
                ),
                (
                    "ac",
                    "a", "a"
                ),
                 (
                    "cbbd",
                    "bb", "bb"
                ),
                (
                    "babad",
                    "bab", "aba"
                ),
                (
                    "papaya",
                    "pap", "apa"
                ),
                (
                    "caba",
                    "aba", "aba"
                )
               
            };
        }
    }
}