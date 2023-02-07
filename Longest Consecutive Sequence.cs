public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        else
        {
            HashSet<int> myArr = new HashSet<int>(nums);
            int counter = 0;
            foreach (int num in myArr)
            {
                if (!myArr.Contains(num - 1))
                {
                    int myNum = num;
                    int currentcount = 1;
                    while (myArr.Contains(myNum + 1))
                    {
                        myNum ++;
                        currentcount ++;
                    }
                    counter = Math.Max(counter, currentcount);
                }
            }
            return counter;
        }
    }
}
