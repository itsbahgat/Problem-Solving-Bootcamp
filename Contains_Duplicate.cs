public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> sett = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            sett.Add(nums[i]);
        }

        if (sett.Count() < nums.Length)
             return true;
        else
             return false;
        

        
    }
}
