using LeetcodeTests;
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetcodeTest
{
    public partial class LeetCodeSolution
    {
        [Theory]
        public void IntegerToRomanTest()
        {
            var solution = new Solution();
            foreach(var i in GetMockDataForIntegerToRoman())
            {
                Assert.AreEqual(i.Output, solution.IntToRoman(i.Input));
            }
        }
        private IList<MockData<int, string>> GetMockDataForIntegerToRoman()
        {
            return new List<MockData<int, string>>()
            {
                new MockData<int, string>()
                {
                    Input = 3, Output = "III"
                },
                new MockData<int, string>()
                {
                    Input = 58, Output = "LVIII"
                },
                new MockData<int, string>()
                {
                    Input = 1994, Output = "MCMXCIV"
                }
            };
        }
    }
}