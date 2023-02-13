public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack <int> stack = new Stack<int>();

        for (int i = 0; i < tokens.Length; i++)
        {
            string myToken = tokens[i];
            if(int.TryParse(myToken , out int num))
            {
                stack.Push(num);
            }
            else
            {
                int op1 = stack.Pop();
                int op2 = stack.Pop();

                if (myToken == "+")
                {
                    stack.Push(op2+op1);
                }
                else if (myToken == "-")
                {
                    stack.Push(op2-op1);

                }
                else if (myToken == "*")
                {
                    stack.Push(op2*op1);
                }
                else if (myToken == "/")
                {
                    stack.Push(op2/op1);
                }
                else
                {
                    throw new ArgumentException("Invalid operator");
                }
            }
        }
        return stack.Pop();
    }
}
