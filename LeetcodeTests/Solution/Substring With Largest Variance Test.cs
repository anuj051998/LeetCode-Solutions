using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTests
{
    public partial class LeetCodeSolution
    {
        private Solution _solultion;

        [SetUp] 
        public void Setup()
        {
            _solultion = new Solution();
        }

        [Theory]
        public void Substring_With_Largest_Variance_Test()
        {
            foreach(var data in GetTestData())
            {
                int res = _solultion.LargestVariance(data.Input);
                Assert.AreEqual(data.Output, res);
            }
        }

        private IList<MockData<string, int>> GetTestData()
        {
            IList<MockData<string, int>> mockDatas = new List<MockData<string, int>>() 
            { 
                new MockData<string, int>{ Input = "aababbb", Output = 3 }
            };
            return mockDatas;
        }

        [TearDown]
        public void Teardown()
        {
            _solultion = null;
        }

    }
}
