using NUnit.Framework;
using System.Collections.Generic;

namespace LeetcodeTests
{
    internal class Rotate_Image_Test
    {
        [Theory]
        public void Test()
        {
            Solution s = new Solution();
            IList<(int[][], int[][])> cases = new List<(int[][], int[][])>()
            {
                (new int[][]{ [5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16] }, new int[][]{ [15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11] }),
                (new int[][]{[1,2,3],[4,5,6],[7,8,9] }, new int[][]{[7,4,1],[8,5,2],[9,6,3] }),
            };

            foreach (var i in cases)
            {
                s.Rotate(i.Item1);
                Assert.AreEqual(i.Item2, i.Item1);
            }
        }
    }
}
