public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> Parentheses = new Dictionary<char, char>()
        {
            [')'] = '(',
            ['}'] = '{',
            [']'] = '['
        };


        foreach (char i in s)
        {
            if (!Parentheses.ContainsKey(i))
                stack.Push(i);
            else if (stack.Count == 0 || stack.Pop() != Parentheses[i])
                return fals e;
        }

        return stack.Count == 0;
    }
}