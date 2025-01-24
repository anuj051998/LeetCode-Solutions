
using NUnit.Framework;
using System.Collections.Generic;

namespace LeetcodeTests
{
    internal class Nim_Game_Test
    {
        [Theory]
        public void NimGameTest(int n)
        {
            Solution solution = new Solution();
            IList<(int, bool)> values = [(5, true), (4, false), (1, true), (2, true)];
            foreach ((int, bool) value in values)
            {
                Assert.AreEqual(solution.CanWinNim(value.Item1), value.Item2);
            }
        }
    }
}
