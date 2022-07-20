public partial class Solution {
    public string AddStrings(string num1, string num2) {
         int len1 = num1.Length, len2 = num2.Length, carry = 0;
            string s = "";
            for (int i = len1-1, j = len2-1; i >= 0 || j >= 0; i--, j--)
            {
                int sum = carry;
                sum += i >= 0 ? int.Parse(num1[i].ToString()) : 0;
                sum += j >= 0 ? int.Parse(num2[j].ToString()) : 0;
                if(sum <= 9)
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
        if(carry != 0)
            {
                s = carry + s;
            }
            return s;
    }
}