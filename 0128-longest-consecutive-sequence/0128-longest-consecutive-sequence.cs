public class Solution {
    public int LongestConsecutive(int[] nums) {
        SortedSet <int> set = new(nums);
            int max = 0, seq = 0;
            if (nums.Length==0)return 0; 
            var old = set.FirstOrDefault();
            foreach(int x in set) 
            {
                if (old + 1 == x)
                {
                    max = ++seq > max ? seq : max;

                }
                else
                    seq = 0;

                old = x;
            }
            return max+1;
    }
}