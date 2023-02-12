public class Solution {
    public int EvalRPN(string[] tokens) {
        
        string temp= string.Empty;
        int firstOperand = 0, lastOperand=1;
        Stack<string> st = new Stack<string>();
        Stack<string> tempStack = new Stack<string>();
        
        
        for (int i = tokens.Length-1; i >= 0; i--)
        {
            st.Push(tokens[i]);
        }
        
        while(st.Count>0){
            temp = st.Pop();                
            
            switch (temp)
            {
                    case "*":
                        lastOperand = int.Parse(tempStack.Pop());
                        firstOperand= int.Parse(tempStack.Pop());

                        st.Push(Convert.ToString(firstOperand * lastOperand));

                        while (tempStack.Count > 0)
                        {
                            st.Push(tempStack.Pop());
                        }
                        break;
                    case "/":
                        lastOperand = int.Parse(tempStack.Pop());
                        firstOperand = int.Parse(tempStack.Pop());

                        st.Push(Convert.ToString(firstOperand / lastOperand));

                        while (tempStack.Count > 2)
                        {
                            st.Push(tempStack.Pop());
                        }
                        
                        break;
                    case "+":
                        lastOperand = int.Parse(tempStack.Pop());
                        firstOperand = int.Parse(tempStack.Pop());

                        st.Push(Convert.ToString(firstOperand + lastOperand));

                        while (tempStack.Count > 0)
                        {
                            st.Push(tempStack.Pop());
                        }
                        break;
                    case "-":
                        lastOperand = int.Parse(tempStack.Pop());
                        firstOperand = int.Parse(tempStack.Pop());

                        st.Push(Convert.ToString(firstOperand - lastOperand));

                        while (tempStack.Count > 0)
                        {
                            st.Push(tempStack.Pop());
                        }
                        break;
                    default:
                        tempStack.Push(temp);
                        break;
                }
        }
        return int.Parse(temp);
    }
}