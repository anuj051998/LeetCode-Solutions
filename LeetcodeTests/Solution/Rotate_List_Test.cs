using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetcodeTests
{
    internal class Rotate_List_Test
    {
        [TestRunner(Name = "Rotate Array")]
        public void Rotate()
        {
            Solution solution = new Solution();
            var mockData = GET_MOCK_DATA();
            foreach (var item in mockData)
            {
                solution.Rotate(item.items, item.k);
                Assert.True(item.items.SequenceEqual(item.output));
            }
        }

        [TestRunner(Name = "Rotation List")]
        public void RunRotateList()
        {
            Solution solution = new Solution();
            var mockData = GET_MOCK_DATA();
            foreach (var item in mockData)
            {
                ListNode res = solution.RotateRight(item.items.FormListNode(), item.k);
                Assert.True(res.FormArray().SequenceEqual(item.output));
            }
        }


        private IList<(int[] items, int k, int[] output)> GET_MOCK_DATA()
        {
            return new List<(int[] items, int k, int[] output)>() {
                //(new int[]{ 1,2 }, 3, new int[]{ 2,1}),
                //(new int[]{-1}, 2, new int[]{ -1 }),
                (new int[]{ 1,2,3,4,5}, 2, new int[]{ 4,5,1,2,3 }),
                (new int[]{ -1,-100,3,99}, 2, new int[]{ 3,99,-1,-100}),
                (new int[]{ 1,2,3,4,5,6,7}, 3,new int[]{ 5,6,7,1,2,3,4}),
            };
        }
    }
}
