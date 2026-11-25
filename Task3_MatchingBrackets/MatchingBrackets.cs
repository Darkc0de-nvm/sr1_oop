using System.Collections.Generic;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        var expectedClosing = new Stack<char>();

        foreach (char c in input)
        {
            switch (c)
            {
                case '(':
                    expectedClosing.Push(')');
                    break;
                case '[':
                    expectedClosing.Push(']');
                    break;
                case '{':
                    expectedClosing.Push('}');
                    break;
                case ')':
                case ']':
                case '}':
                    if (expectedClosing.Count == 0 || expectedClosing.Pop() != c)
                    {
                        return false;
                    }
                    break;
            }
        }
        return expectedClosing.Count == 0;
    }
}