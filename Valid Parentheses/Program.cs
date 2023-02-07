namespace Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "))";
            Console.WriteLine(IsValid(s));
        }
        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0) { return false; } // to make sure the string consists of pairs
            Stack<char> stack = new ();
            for(int i=0;i<s.Length;i++)
            {
                switch (s[i])
                {
                    case '(':
                        stack.Push(s[i]);
                        break;
                    case '[':
                        stack.Push(s[i]);
                        break;
                    case '{':
                        stack.Push(s[i]);
                        break;
                    case ')': 
                        if (stack.Count > 0)
                        {
                            if (stack.Peek() == '(')
                                stack.Pop();
                            else return false;
                        }
                        break;
                    case '}':
                        if (stack.Count > 0)
                        {
                            if (stack.Peek() == '{')
                                stack.Pop();
                            else return false;
                        }
                        break;
                    case ']':
                        if (stack.Count > 0)
                        {
                            if (stack.Peek() == '[')
                                stack.Pop();
                            else return false;
                        }
                        break;
                }
            }
            if (stack.Count == 0) return true;
            else
                    return false;
        }
    }
}