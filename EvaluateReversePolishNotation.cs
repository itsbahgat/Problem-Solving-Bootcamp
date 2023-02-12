public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> sums = new();
            int sz = tokens.Length;
            for (int i = 0; i < sz; i++)
            {
                if (tokens[i] == "+"|| tokens[i] == "*"|| tokens[i] == "/" || tokens[i] == "-")
                {
                    int x, y;
                    
                    
                    y = sums.Pop();
                   

                    x = sums.Pop();
                   
                    switch (tokens[i])
                    {
                        case "+":
                            sums.Push(x + y);
                           
                            break;
                        case "-":
                            sums.Push(x - y);
                     
                            break;
                        case "/":
                            sums.Push(x / y);
                     
                            break;
                        case "*":
                            sums.Push(x * y);
                     
                            break;
                    }
                }
                else sums.Push(int.Parse(tokens[i]));
            }
            return sums.Peek();
 
    }
}
