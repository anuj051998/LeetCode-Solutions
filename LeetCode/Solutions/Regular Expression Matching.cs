using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode.Solutions
{
    public partial class Solution
    {
        public bool IsMatch(string s, string p)
        {
            return Regex.Match(s, p).Success;
        }
    }
}
