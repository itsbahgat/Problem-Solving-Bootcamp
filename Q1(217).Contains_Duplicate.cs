public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {


        HashSet<int> numbers = new HashSet<int>();
        numbers.Add(nums[0]);

        for (int i = 1; i < nums.Count(); i++)
        {
            if (numbers.Contains(nums[i]))
                return true;
            else
                numbers.Add(nums[i]);
        }
        return false;
    }
}