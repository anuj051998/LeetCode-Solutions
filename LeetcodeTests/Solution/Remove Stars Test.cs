using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
    public class Remove_Stars_Test
    {
        [TestCase("leet**cod*e", "lecoe")]
        [TestCase("erase*****", "")]
        [TestRunner]
        public void RemoveStars_Test(string s, string expected)
        {
            Solution solution = new Solution();
            string res = solution.RemoveStars(s);
            Assert.AreEqual(expected, res);
        }
    }
}
