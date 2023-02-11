    public class MinStack
    {
        Stack<int> stack;
        Stack<int> Minstack;

        public MinStack()
        {
            stack = new();
            Minstack = new();

        }

        public void Push(int val)
        {
            stack.Push(val);
            if (Minstack.Count==0 || val <= Minstack.Peek())
                Minstack.Push(val);
        }

        public void Pop()
        {
            if (stack.Peek() == Minstack.Peek() )
                Minstack.Pop();
            stack.Pop();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return Minstack.Peek();
        }
    }