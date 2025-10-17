namespace ValidParentheses;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.IsValid("(){}[][]["));
    }
}

public class Solution
{
    public static bool IsValid(string s)
    {
        Stack<char> parenthesesStack = new Stack<char>();

        foreach (var ch in s)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                parenthesesStack.Push(ch);
            }
            else
            {
                if (parenthesesStack.Count == 0) return false;
                if ((ch == ')' && parenthesesStack.Peek() != '(') ||
                    (ch == '}' && parenthesesStack.Peek() != '{') ||
                    (ch == ']' && parenthesesStack.Peek() != '[')) return false;

                parenthesesStack.Pop();
            }
        }

        return parenthesesStack.Count == 0;
    }
}