public bool IsValid(string s)
{
	Stack<char> stack = new Stack<char>();
	if (s.Length % 2 == 1)
		return false;
	for (int i = 0; i < s.Length; i++)
	{
		if (s[i] is '(' or '[' or '{')
		{
			stack.Push(s[i]);
		}
		else if (stack.Count == 0)
		{
			return false;
		}
		else if (s[i] is ')' && stack.Peek() == '(')
		{
			stack.Pop();
		}
		else if (s[i] is ']' && stack.Peek() == '[')
		{
			stack.Pop();
		}
		else if (s[i] is '}' && stack.Peek() == '{')
		{
			stack.Pop();
		}
		else
		{
			return false;
		}

	}
	return stack.Count == 0;
}