using System.Collections;

public partial class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }

        Stack stack = new();
        foreach (char x in s)
        {
            if ("{[(".Contains(x))
            {
                stack.Push(x);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char popItem = (char)stack.Pop();
                char temp = x == ')' ? '(' : x == '}' ? '{' : '[';
                if (popItem != temp)
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}