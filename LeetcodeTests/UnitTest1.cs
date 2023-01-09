using NUnit.Framework;
using System.Collections.Generic;
namespace LeetCodeTest
{
    public partial class MockData
    {
        public static IList<(string[], int, IList<string>)> GetDataForJustifyText()
        {
            IList<(string[], int, IList<string>)> dataSet = new List<(string[], int, IList<string>)> {
            (
                new string[]{ "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" },
                20,
                new string[] { "Science  is  what we",
                                "understand      well",
                                "enough to explain to",
                                "a  computer.  Art is",
                                "everything  else  we",
                                "do                  " }
            ),
            (
                new string[]{ "What","must","be","acknowledgment","shall","be" },
                16,
                new string[] { "What   must   be",
                                "acknowledgment  ",
                                "shall be        " }

            ),
            (
            new string[]{ "This", "is", "an", "example", "of", "text", "justification." },
            16,
            new string[]{ "This    is    an", "example  of text", "justification.  " }
            )
        };
            return dataSet;
        }
    }
    public partial class LeetCodeSolution
    {
        [Test]
        public void Test_Text_Justification()
        {
            IList<(string[], int, IList<string>)> mockTestData = MockData.GetDataForJustifyText();

            Solution solution = new();
            foreach ((string[], int, IList<string>) dataSet in mockTestData)
            {
                IList<string> result = solution.FullJustify(dataSet.Item1, dataSet.Item2);
                Assert.IsTrue(Check_Text_JustificationResult(result, dataSet.Item3));
            }
        }

        public bool Check_Text_JustificationResult(IList<string> response, IList<string> expectedRes)
        {
            if (response.Count != expectedRes.Count)
            {
                return false;
            }
            for (int i = 0; i < response.Count; i++)
            {
                if (response[i] != expectedRes[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}