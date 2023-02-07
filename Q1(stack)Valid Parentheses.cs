public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> s1 = new Stack<char>(s);



        foreach (char character in s)//O(n)
        {
            if (character == '(' || character == '[' || character == '{') //O(1)
                s1.Push(character); //O(1) average  (O(n) if full)
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