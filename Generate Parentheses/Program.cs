using System.Linq;

namespace Generate_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = GenerateParenthesis(3);
            Console.WriteLine(x.Count);
            foreach (var item in x) { Console.WriteLine(item ); }
        }
        public static IList<string> GenerateParenthesis(int n)
        {
            Stack<string> stk = new Stack<string>();
            List<string> result = new List<string>();
            int open = 0;
            int close = 0;
            void traking(int open, int close)
            {
                if (open == close && open == n) { result.Add(String.Join("", stk.ToArray().Reverse())); }
                if (open < n)
                {
                    stk.Push("(");
                    traking(open + 1, close);
                    stk.Pop();
                }
                if (close < open)
                {
                    stk.Push(")");
                    traking(open, close + 1);
                    stk.Pop();
                }
            }
            traking(0, 0);
            return result;
        }
    }
}