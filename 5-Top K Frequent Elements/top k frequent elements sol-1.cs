public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> d = new();

        for(int i=0;i<nums.Length;i++) {
            if(!d.ContainsKey(nums[i])) {
                d.Add(nums[i],1);
            } else {
                d[nums[i]]++;
            }
        }
        d =d.OrderBy(x=>-x.Value).ToDictionary(x=>x.Key,x=>x.Value);
        return d.Keys.ToArray()[..k];
    }
}