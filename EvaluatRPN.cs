public static int EvalRPN(string[] tokens)
{

	Stack<int> stack = new Stack<int>();
	for (int i = 0; i < tokens.Length; i++)
	{
		if (int.TryParse(tokens[i], out int num))
		{
			stack.Push(num);
		}
		else
		{
			int a = stack.Pop();
			int b = stack.Pop();
			switch (tokens[i])
			{
				case "+": stack.Push(b + a); break;

				case "-": stack.Push(b - a); break;

				case "*": stack.Push(b * a); break;

				case "/": stack.Push(b / a); break;


			}

		}



	}

	return stack.Pop();
}
