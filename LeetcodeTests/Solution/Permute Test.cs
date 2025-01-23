using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCodeTest
{
    public partial class LeetCodeSolution
    {
        [TestRunner(maxTimeMilliseconds: 20)]
        public void PERMUTE_TEST()
        {
            IList<(char[] chars, IList<IList<char>>)> mockData = PERMUTE_TEST_MOCK_DATA();

            Solution solution = new();
            foreach ((char[] chars, IList<IList<char>> listChars) in mockData)
            {
                IList<IList<char>> res = new List<IList<char>>();
                //solution.FIND_PERMUTATION(chars, 0, chars.Length, res);
                Assert.IsTrue(IsResponseEqual(res, listChars));
            }
        }
        private bool IsResponseEqual(IList<IList<char>> res, IList<IList<char>> exp)
        {
            if (res.Count != exp.Count)
            {
                return false;
            }
            for(int i = 0; i < res.Count; i++)
            {
                if (res[i].Count != exp[i].Count)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Input test data
        /// </summary>
        /// <returns></returns>
        private IList<(char[] chars, IList<IList<char>>)> PERMUTE_TEST_MOCK_DATA()
        {
            return new List<(char[], IList<IList<char>>)> {
                (
                 new char[] { 'A', 'B' },
                 new List<IList<char>> {
                     new List<char> { 'A', 'B' },
                     new List<char> { 'B', 'A' }
                 }),
                 (
                 new char[] { 'A', 'B', 'C' },
                 new List<IList<char>> {
                     new List<char> { 'A', 'B', 'C' },
                     new List<char> { 'A', 'C', 'B' },
                     new List<char> { 'B', 'A', 'C' },
                     new List<char> { 'C', 'B', 'A' },
                     new List<char> { 'B', 'C', 'A' },
                     new List<char> { 'C', 'A', 'B' }
                 }
                )
        };
        }
    }
}