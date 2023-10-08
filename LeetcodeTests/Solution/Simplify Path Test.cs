using NUnit.Framework;
using System.Collections.Generic;

namespace LeetcodeTests
{
    internal class Simplify_Path_Test
    {
        [TestRunner]
        [Test]
        public void Test()
        {
            Solution solution = new Solution();
            solution.SimplifyPath(null);
            foreach((string input, string output) item in GET_MOCK_DATA())
            {
                string res = solution.SimplifyPath(item.input);
                Assert.AreEqual(item.output, res);
            }
        }

        private IList<(string input, string output)> GET_MOCK_DATA()
        {
            return new List<(string input, string output)> {
                ("///", "/"),
                ("/", "/"),
                ("/a/./b/../../c/", "/c"),
                ("/../anuj/vishwakarma/../", "/anuj"),
                ("/home//foo/","/home/foo"),
                ( "/home/","/home" ),
                ("/../", "/"),
            };
        }
    }
}
