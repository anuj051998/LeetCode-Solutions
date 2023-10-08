using System.Text;

public partial class Solution
{
    public string RemoveStars(string s)
    {
        StringBuilder sb = new StringBuilder();
        int index = 0;
        int head = 0;
        while(index < s.Length)
        {
            if (s[index] == '*')
            {
                sb.Remove(--head, 1);
            }
            else
            {
                sb.Append(s[index]);
                head++;
            }
            index++;
        }
        return sb.ToString();
    }
}