using System.Collections.Generic;
using System.Linq;

public partial class Solution
{
    public string RestoreString(string s, int[] indices)
    {
        IDictionary<int, char> di = new Dictionary<int, char>();
        for (int i = 0; i < indices.Length; i++)
        {
            di.Add(indices[i], s[i]);
        }
        return string.Join("", di.OrderBy(k => k.Key).Select(x => x.Value));
    }
}