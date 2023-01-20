public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> s = new ();
        foreach(int num in nums) {
            if(s.Contains(num)) 
                return true;
            s.Add(num);
        }
        return false;
    }
}