// See https://aka.ms/new-console-template for more information
int[] nums = {3,2,4};
int target = 6;
int[] ans = Solution.TwoSum(nums, target);
Console.WriteLine($"{ ans[0]}, {ans[1]}");

//  Two Sum
class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        #region sol1
        //int[] ans ;
        //ans = new int[2] {-1,-1};
        //for (int i=0; i<nums.Length; i++)
        //{
        //    for(int j=i+1; j<nums.Length; j++)
        //    {
        //        if (nums[i] + nums[j] == target)
        //        {
        //            ans[0] = i;
        //            ans[1] = j;
        //        }
        //    }
        //}
        //return ans;
        #endregion
        #region sol2
        for(int i=0; i< nums.Length; i++) { 
            int diff = target - nums[i];
            int pos = Array.IndexOf(nums, diff, i + 1);
            if ((pos != i) && (pos != -1))
            {
                //Console.WriteLine($"{pos},{diff}");
                return new int[] {i, Array.IndexOf(nums, diff, i+1) }; }
        }
        return new int[] {-1,-1};
        #endregion
    }
}