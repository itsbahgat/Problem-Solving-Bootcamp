public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> d = new ();

        for(int i=0;i<nums.Length;i++) {
            if(!d.ContainsKey(nums[i]))
                d[nums[i]]=i;
            if(d.ContainsKey(target-nums[i]) && i!=d[target-nums[i]])
                return new int[] {i,d[target-nums[i]]};
        }
        return null;
    }
}