public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int sum = 0;
        for (int i = 0; inums.Length; i++)
        {
            for (int j = 0; jnums.Length; j++)
            {
                if (i != j)
                {
                    sum = nums[i] + nums[j];
                    if (sum == target)
                        return new int[] { i, j };
                }
            }
        }
        return new int[] { 0, 0 };
    }
}