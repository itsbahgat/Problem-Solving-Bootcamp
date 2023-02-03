public class Solution
{
    public int LongestConsecutive(int[] nums)
    {

        Array.Sort(nums);
        int counter = 1;
        int max = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == (nums[i - 1] + 1))
            {
                counter++;
                if (counter > max)
                    max = counter;
            }
            else if (nums[i] == (nums[i - 1]))
            {
                continue;

            }
            else
            {
                counter = 1;

            }

        }
        if (nums.Length == 0) return 0;
        return max;
    }
}