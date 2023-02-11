public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> st = new (tokens.Length*2/3);
        int num1,num2;
        foreach(string token in tokens) {
            if(int.TryParse(token,out num1)) {
                st.Push(num1);
            } else {
                num2 = st.Pop();
                num1 = st.Pop();
                switch(token[0]) {
                    case '+':
                        st.Push(num1+num2);
                        break;
                    case '-':
                        st.Push(num1-num2);
                        break;
                    case '*':
                        st.Push(num1*num2);
                        break;
                    case '/':
                        st.Push(num1/num2);
                        break;
                }
            }
        }
        return st.First();
    }
}