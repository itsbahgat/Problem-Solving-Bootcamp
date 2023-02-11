public class Solution {
    public int EvalRPN(string[] tokens) {
                    Stack<int> operands = new();
            int result;

            for (int i = 0; i < tokens.Length; i++)
            {
                if ( Int32.TryParse( tokens[i], out int op) )
                {
                    operands.Push(op);
                }
                else
                {
                    int popedOperand1 = operands.Pop();
                    int popedOperand2 = operands.Pop();
                    switch (tokens[i])
                    {
                        case "*":
                            result= popedOperand2*popedOperand1;
                            operands.Push(result);
                            break;

                        case "/":
                            result = popedOperand2 / popedOperand1;
                            operands.Push(result);
                            break;

                        case "+":
                            result = popedOperand2 + popedOperand1;
                            operands.Push(result);
                            break;

                        case "-":
                            result = popedOperand2 - popedOperand1;
                            operands.Push(result);
                            break;


                    }
                }
            }
            return operands.Pop();
        
    }
}