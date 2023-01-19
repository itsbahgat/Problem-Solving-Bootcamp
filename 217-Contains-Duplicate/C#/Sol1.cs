public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        HashSet<int> set = nums.ToHashSet();
        if (set.Count < nums.Length)
            return true;

        return false;
    }
}