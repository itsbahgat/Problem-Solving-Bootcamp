 public class Solution
{        /*EX:Input: tokens = ["2","1","+","3","*"]
            Output: 9
            Explanation: ((2 + 1) * 3) = 9
            */
        public int EvalRPN(string[] tokens)
        {
            Stack<int> s = new Stack<int>();

            for(int i=0;i<tokens.Length;i++)
            {   int ch;
                if (int.TryParse(tokens[i], out ch))
                {   
                    s.Push(ch);

                }
                else
                {
                    int num1=s.Pop();
                    int num2 = s.Pop();
                    int res = 0;
                    switch (tokens[i]) {
                        case "+":
                           res = num2 + num1;
                           break;
                        case "-":
                            res = num2 - num1;
                            break;
                        case "*":
                            res = num2 * num1;
                            break;
                        case "/":
                            res = num2 / num1;
                            break;            
                    }
                    s.Push(res);

                }
            }
            return s.Pop();
        }
 }