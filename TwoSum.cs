///way 1
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        for (int i=0;i<nums.Length;i++)
        {
            int dif = target - nums[i];
            int index=Array.BinarySearch(nums,dif);
            if((index>-1)&&(index!=i))
            {
                return new int[] { i, index };
            }

        }
        return new int[] {-1,-1};
    }
}


/////way 2
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i=0;i<nums.Length;i++)
        {
            int d=target-nums[i];
            int index = Array.IndexOf(nums,d,i+1);
            if((index!=i)&&(index!=-1))
            {
                return new int[]{i,index};
           }
        }
        return new int [] {-1,-1};
       

    }
}
