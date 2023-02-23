namespace Daily_Temperatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 89, 62, 70, 58, 47, 47, 46, 76, 100, 70 };
            var list = DailyTemperatures(arr);
            foreach(var item in list )
            {
                Console.WriteLine(item);
            }
        }
        public static int[] DailyTemperatures(int[] temperatures)
        {
            #region first -- timeout
            //int[] result = new int[temperatures.Length];
            //for (int i=0; i<temperatures.Length; i++)
            //{
            //    int res = Array.FindIndex(temperatures, i + 1, x => x > temperatures[i]);
            //    result[i] = (res == -1) ? 0 : res - i;
            //}
            //return result; 
            #endregion

            #region hmmm
            //int[] result = new int[temperatures.Length];
            //Stack<KeyValuePair<int, int>> stack = new Stack<KeyValuePair<int, int>>();
            //for (int i = 0; i < temperatures.Length; i++)
            //{
            //    if (stack.Count > 0 && temperatures[i] < stack.Peek().Key)
            //        stack.Push(new KeyValuePair<int, int>(temperatures[i], i));
            //    else if (stack.Count > 0)
            //    {
            //        while (stack.Peek().Key< temperatures[i])
            //        {
            //            result[stack.Peek().Value] = 
            //        }
            //    }
            //}
            //return result; 
            #endregion

            int[] result = new int[temperatures.Length];
            for (int i = 0; i < temperatures.Length; i++)
            {
                result[i] = 0;
                for(int j = i+1; j < temperatures.Length; j++)
                {
                    if (temperatures[j] > temperatures[i])
                    {
                        result[i] = j - i; break;
                    }
                }
            }
            return result;
        }
    }
}