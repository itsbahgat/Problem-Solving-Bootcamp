public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> s = new ();
        for(int i=0;i<nums.Length;i++) {
            s.Add(nums[i]);
        }
        if(s.Count==nums.Length) {
            return false;
        }
        return true;
    }
}