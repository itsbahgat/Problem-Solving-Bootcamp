public class Solution {
    public bool IsValid(string s) {
        if (s.Length == 0 || s.Length%2 != 0)
            return false;
        Stack<char> st = new(s);
        Stack<char> tmp = new();
        while(st.Count>0) {
            char c1 = st.Pop();
            if(tmp.Count>0 && (tmp.Peek()==c1+1 || tmp.Peek()==c1+2))
                tmp.Pop();
            else tmp.Push(c1);
        }
        return tmp.Count==0;
    }
}