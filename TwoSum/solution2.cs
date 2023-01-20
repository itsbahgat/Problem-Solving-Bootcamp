public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> results = new Dictionary<int,int>();
        for(int i=0; i<nums.Length;i++){
            if(results.ContainsKey(target-nums[i])){
                return new int[]{results[target-nums[i]],i};
            }
            results[nums[i]] = i;
        }
    return null;     
}
