public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> number = new Stack<int>();

        var op = new Dictionary<string, Func<int, int, int>>
        {
            {"+" , (y , x)=>x+y},
            {"-" , (y, x) => x-y},
            {"*" , (y,x) => x * y},
            {"/" , (y,x) => x / y},
        };

        for (int i = 0; i < tokens.Length; i++)
        {
            if (!op.ContainsKey(tokens[i]))
            {
                number.Push(Convert.ToInt32(tokens[i]));
            }
            else
            {
                number.Push(op[tokens[i]](number.Pop(), number.Pop()));
            }
        }

        return number.Pop();
    }

}