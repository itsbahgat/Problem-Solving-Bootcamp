public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] sol = new int[2];
        int[] indecies = new int[2];


        Dictionary<int, int> dic = new Dictionary<int, int>();
        Dictionary<int, int> dublicates = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
                dublicates[nums[i]] = i;
            else
               dic[nums[i]] = i;
            
        }


        for (int i = 0; i < nums.Length; i++)
        {
            sol[0] = nums[i];
            sol[1] = target - nums[i];

            indecies[0] = i;

            if (sol[1] == sol[0] && dublicates.ContainsKey(nums[i])) 
            {
             indecies[1]=dublicates[nums[i]];
                break;
            }


            if (dic.ContainsKey(sol[1]) && i != dic[sol[1]])
            {
                indecies[1] = dic[sol[1]];
                break;
            }
        }

        return indecies;

    }
}