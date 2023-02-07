public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 == 1) return false; //if size is odd => wrong
        Stack<char> s1 = new Stack<char>(s.Length % 2); //prevent add complixity of array expansion


        foreach (char character in s)//O(n)
        {
            if (character == '(' || character == '[' || character == '{') //O(1)
                s1.Push(character); //O(1) average  (O(n) if expansion)
            else
            {
                if (s1.Count == 0) return false;// entered a closing parentheses while stack is empty  //O(1)
                if (character == ')' && s1.Peek() == '(' || character == ']' && s1.Peek() == '[' || character == '}' && s1.Peek() == '{') //O(1)
                    s1.Pop(); //O(1)
                else return false; //O(1)
            }
        }
        if (s1.Count == 0) //stack not empty //O(1)
            return true;
        else return false;

    }
}