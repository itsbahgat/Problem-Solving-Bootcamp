namespace Min_Stack
{
    internal class MinStack
    {
        Stack<int> stack;
        Stack<int> minStack;
        static void Main(string[] args)
        {
            MinStack s = new MinStack();
            s.Push(1);
            s.Push(5);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Pop();
            Console.WriteLine(s.GetMin());
            s.Pop();
            s.Pop();
            s.Pop();
            Console.WriteLine(s.GetMin());
            s.Pop();
            Console.WriteLine(s.GetMin());
        }
        public MinStack()
        {
            stack = new Stack<int>();
            minStack= new Stack<int>();
        }

        public void Push(int val)
        {
            if(stack.Count == 0) minStack.Push( val);
            else if (val <= minStack.Peek()) minStack.Push(val);
            stack.Push(val);
        }

        public void Pop()
        {
            if(minStack.Peek()==stack.Peek())
                minStack.Pop();
            stack.Pop();
        }

        public int Top()
        {
            if(stack.Count == 0) { return 0; }
            else { return stack.Peek(); }
        }

        public int GetMin()
        {
            if (stack.Count != 0 ) return minStack.Peek();
            else return 0;
            
        }
    }
}