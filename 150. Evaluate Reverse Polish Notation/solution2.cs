public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> number = new Stack<int>();

        foreach (string s in tokens)
        {
            switch (s)
            {
                case "+":
                    number.Push(number.Pop() + number.Pop());
                    break;
                case "-":
                    int a = number.Pop();
                    int b = number.Pop();
                    number.Push(b - a);
                    break;
                case "*":
                    number.Push(number.Pop() * number.Pop());
                    break;
                case "/":
                    int c = number.Pop();
                    int d = number.Pop();
                    number.Push(d / c);
                    break;
                default:
                    number.Push(Convert.ToInt32(s));
                    break;
            }
        }

        return number.Pop();
    }

}