public int[] TwoSum(int[] nums, int target) {
        int sum=0;
        int[] results = new int[2];
        for(int i=0; i<nums.Length;i++){
            sum = nums[i];
            for(int j=i+1; j<nums.Length;j++){
                if(sum + nums[j] == target){
                    results[0] = i;
                    results[1] = j;
                    return results;
                }
            }
        }
    return results;
}
