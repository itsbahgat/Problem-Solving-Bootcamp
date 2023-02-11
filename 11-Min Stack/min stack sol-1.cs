public class MinStack {

    List<int> minElems = new();
    List<int> elems = new();

    public MinStack() {

    }
    
    public void Push(int val) {
        elems.Add(val);
        if(minElems.Count==0 || minElems[minElems.Count-1]>=val)
            minElems.Add(val);
    }
    
    public void Pop() {
        if(elems[elems.Count-1] == minElems[minElems.Count-1])
            minElems.RemoveAt(minElems.Count-1);
        elems.RemoveAt(elems.Count-1);
    }
    
    public int Top() {
        return elems[elems.Count-1];
    }
    
    public int GetMin() {
        return minElems[minElems.Count-1];
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */