using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Solution
{
    public static string AddString(string num1, string num2)
    {
        int len1 = num1.Length, len2 = num2.Length, carry = 0;
        string s = "";
        for (int i = len1 - 1, j = len2 - 1; i >= 0 || j >= 0; i--, j--)
        {
            int sum = carry;
            sum += i >= 0 ? int.Parse(num1[i].ToString()) : 0;
            sum += j >= 0 ? int.Parse(num2[j].ToString()) : 0;
            if (sum <= 9)
            {
                s = sum.ToString() + s;
                carry = 0;
            }
            else
            {
                carry = sum / 10;
                s = (sum % 10).ToString() + s;
            }
        }
        if (carry != 0)
        {
            s = carry + s;
        }
        return s;
    }
    public string Multiply(string num1, string num2)
    {
        List<string> li = new();
        StringBuilder n = new();
        for (int i = num1.Length - 1; i >= 0; i--)
        {
            List<int> temporary = new();
            int carry = 0;
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                int t = (int.Parse(num1[i].ToString()) * int.Parse(num2[j].ToString())) + carry;
                if (t > 9)
                {
                    temporary.Add(t % 10);
                    carry = t / 10;
                }
                else
                {
                    temporary.Add(t);
                    carry = 0;
                }
            }
            if (carry != 0)
            {
                temporary.Add(carry);
            }

            temporary.Reverse();
            string res = "";
            temporary.ForEach(x => res += x);
            res += n.ToString().Replace("1", "");
            _ = n.Append('0');
            li.Add(res);
        }
        string op = "0";
        for (int i = 0; i < li.Count; i++)
        {
            op = AddString(op, li[i].ToString());
        }

        return op.Count(x => x == '0') == op.Length ? "0" : op;
    }
}