internal class Program
{
	public static void GenerateParenthesis(int n, int open, int close, string str, IList<string> result)
	{
		if (str.Length == n * 2)
		{
			result.Add(str);
			return;
		}
		if (open < n)
			GenerateParenthesis(n, open + 1, close, str + "(", result);
		// Generate close bracket
		if (close < n && close < open)
			GenerateParenthesis(n, open, close + 1, str + ")", result);
	}

	public static IList<string> GenerateParenthesis(int n)
	{
		IList<string> list = new List<string>();
		GenerateParenthesis(n, 0, 0, "", list);
		return list;
	}
	private static void Main(string[] args)
	{
			IList<string> list= GenerateParenthesis(3);
		foreach(string str in list)
		{
			Console.WriteLine(str);
		}

	}
}