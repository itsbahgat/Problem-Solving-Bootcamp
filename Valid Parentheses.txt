public class Solution {
    
        public bool IsValid(string s)
{
    Stack<char> Parentheses = new Stack<char>();

    for (int i = 0; i < s.Length; i++)
    {
        char c = s[i];
        if (c == '(' || c == '[' || c == '{')
        {
            Parentheses.Push(c);
        }
        else if (Parentheses.Count == 0)
        {
            return false;
        }
        else if (c == ')' && Parentheses.Peek() == '(')
        {
            Parentheses.Pop();
        }
        else if (c == '}' && Parentheses.Peek() == '{')
        {
            Parentheses.Pop();
        }
        else if (c == ']' && Parentheses.Peek() == '[')
        {
            Parentheses.Pop();
        }
        else
        {
            return false;
        }
    }
    return Parentheses.Count == 0;
}

}
