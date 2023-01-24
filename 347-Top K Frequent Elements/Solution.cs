public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
                dic[nums[i]]++;
            else
                dic.Add(nums[i], 1);
        }
        int[] res = new int[k];
        int j = 0;

        foreach (KeyValuePair<int, int> item in dic.OrderByDescending(key => key.Value))
        {
            res[j] = item.Key;
            j++;
            if (j == k)
                break;
        }
        return res;


    }
}
