public class MinStack
{
    // Solution by user : Asmaagamall https://github.com/Asmaagamall
    Stack arr;
    int min;


    public MinStack()
    {
        arr = new Stack();
        min = Int32.MaxValue;

    }

    public void Push(int val)
    {

        if (val <= min)
        {
            arr.Push(min);
            min = val;
        }

        arr.Push(val);

    }

    public void Pop()
    {

        int val = (int)arr.Pop();
        if (val == min)
        {

            min = (int)arr.Pop();
        }
    }

    public int Top()
    {
        return (int)arr.Peek(); // Top element.


    }

    public int GetMin()
    {
        return min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 * You must implement a solution with O(1) time complexity for each function.
 */
