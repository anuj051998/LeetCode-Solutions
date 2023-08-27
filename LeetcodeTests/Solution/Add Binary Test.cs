using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
    internal class Add_Binary_Test
    {
        [Theory]
        public void Test()
        {
            Solution s = new Solution();
            string res = s.AddBinary("10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101", "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011");
            Assert.AreEqual("1011101010100111011110011101011101001011000000111011010000010101011010111100010101111111011111000011", res);
        }
    }
}
