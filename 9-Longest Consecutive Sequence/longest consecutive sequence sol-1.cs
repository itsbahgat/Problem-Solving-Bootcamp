public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0)
            return 0;
        HashSet<int> set = new HashSet<int>(nums);
        int counter,maxCounter=0;
        foreach(int num in set) {
            if(!set.Contains(num-1)) {
                counter=1;
                while(set.Contains(num+counter)) {                    
                    counter++;
                }
                if(counter>maxCounter)
                    maxCounter=counter;
            }
        }
        return maxCounter;
    }
}