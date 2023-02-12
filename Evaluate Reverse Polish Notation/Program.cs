using System.Numerics;

namespace Evaluate_Reverse_Polish_Notation
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string [] tokens = {"2", "1", "+", "3", "*"};
            Console.WriteLine(EvalRPN(tokens));
        }

        public static int EvalRPN(string[] tokens)
        {
            #region first sol
            //var stack = new Stack<int>();
            //int num1, num2;
            //for (int i =0; i < tokens.Length; i++)
            //{
            //    if (int.TryParse(tokens[i], out num1))
            //        stack.Push(num1);
            //    else
            //    {
            //        num2 = stack.Pop();
            //        num1 = stack.Pop();
            //        switch (tokens[i])
            //        {
            //            case "+":
            //                stack.Push(num1 + num2);
            //                break;
            //            case "-":
            //                stack.Push(num1 - num2);
            //                break; 
            //            case "*":
            //                stack.Push(num1 * num2);
            //                break;
            //            case "/":
            //                stack.Push(num1 / num2);
            //                break;
            //        }
            //    }
            //}
            //    return stack.Pop(); 
            #endregion

            var stack = new Stack<int>();
            var op = new Dictionary<string, Func<int, int, int>>
            {
                { "+", (y, x) => x + y },
                { "-", (y, x) => x - y },
                { "*", (y, x) => x * y },
                { "/", (y, x) => x / y }
            };
            for (int i =0; i<tokens.Length;i++)
            {
                if (!op.ContainsKey(tokens[i]))
                {
                    stack.Push(int.Parse(tokens[i]));
                }
                else
                {
                    stack.Push(op[tokens[i]](stack.Pop(), stack.Pop()));
                }
            }
            return stack.Pop();
        }
    }
}