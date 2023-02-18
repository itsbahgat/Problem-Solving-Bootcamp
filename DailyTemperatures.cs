public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int sz = temperatures.Length;
                int[] arr = new int[temperatures.Length];
                Stack<Tuple<int, int>> pairStack = new Stack<Tuple<int, int>>();
                for(int i = 0; i < sz; i++)
                {
                    if (pairStack.Count == 0) { pairStack.Push(Tuple.Create(temperatures[i],i)); }
                    else if (temperatures[i] > pairStack.Peek().Item1)
                    {
                        while (pairStack.Count > 0 && temperatures[i] > pairStack.Peek().Item1 )
                        {
                            Tuple<int, int> top = pairStack.Pop();
                            arr[top.Item2] = i - top.Item2;
                        }
                        
                    }
                    pairStack.Push(Tuple.Create(temperatures[i], i));

                }
                return arr;
    }
}
