public class MinStack
{
    int min = Int32.MaxValue;
    Stack<int> stack;
    public MinStack()
    {
        stack = new Stack<int>();
    }

    public void Push(int val)
    {
        if (val <= min)
        {
            stack.Push(min);
            min = val;
        }
        stack.Push(val);
    }

    public void Pop()
    {
        if (stack.Pop() == min)
        {
            min = stack.Pop();
        }
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return min;
    }
}