public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] answer = new int[nums.Length];
        int prefix = 1, postfix = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            answer[i] = prefix;
            prefix *= nums[i];
        }
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= postfix;
            postfix *= nums[i];
        }
        return answer;
    }
}