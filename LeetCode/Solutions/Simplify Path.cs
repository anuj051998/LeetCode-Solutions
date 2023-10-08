using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
public partial class Solution
{
    public string SimplifyPath(string path)
    {
        Debug.Assert(path == null, "path should not be null");
        if(path.Length == 1)
        {
            return "/";
        }
        if (!path.Contains('.'))
        {
            string result = string.Join('/', path.Replace(@"//", "/").Split('/').Select(x => x.Length > 0 && x != "." ? x : ""));
            return result.TrimEnd('/').Length > 1 ? result.TrimEnd('/') : result;
        }

        IList<string> list = new List<string>();
        int index = 0;
        path.Replace(@"//","/").Split('/').ToList().ForEach(x =>
        {
            if (!string.IsNullOrEmpty(x))
            {
                if (x == "..")
                {
                    if (list.Count != 0)
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                }
                else if (x != ".")
                {
                    list.Add($"{x}");
                }
                index++;
            }
        });

        string res = $"/{string.Join('/', list)}";
        return res.Length > 1 ? res.TrimEnd('/') : res;
    }
}