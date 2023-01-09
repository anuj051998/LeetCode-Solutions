using System.Text;

public partial class Solution
{
    public string DefangIPaddr(string address)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < address.Length; i++)
        {
            _ = address[i] == '.' ? builder.Append("[.]") : builder.Append(address[i]);
        }
        return builder.ToString();
    }
}