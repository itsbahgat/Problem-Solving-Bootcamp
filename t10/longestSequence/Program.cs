namespace longestSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] nums = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine(LongestConsecutive(nums));
         int LongestConsecutive(int[] nums)
        {
                #region thought 1 time exceed
                //var hSet = nums.ToHashSet();
                //int seq = 0;
                //int longest = 0;
                //foreach(var item in hSet)
                //{
                //    seq = 0;
                //    var element = item;
                //    while(hSet.Contains(element)) 
                //    { element += 1;
                //        seq++;
                //    }
                //    longest = Math.Max(longest, seq);
                //}
                //return longest; 
                #endregion
                #region refactoring by GPT
                var hSet = nums.ToHashSet();
                int longest = 0;
                foreach (var num in hSet)
                {
                    if (!hSet.Contains(num - 1))
                    {
                        int current = num;
                        int currentSeq = 1;
                        while (hSet.Contains(current + 1))
                        {
                            current++;
                            currentSeq++;
                        }
                        longest = Math.Max(longest, currentSeq);
                    }
                }
                return longest; 
                #endregion
            }
        }
    }
}