public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {


        Dictionary<int, int> freq = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (freq.ContainsKey(nums[i]))
            {
                freq[nums[i]] += 1;
            }
            else
                freq.Add(nums[i], 0);

        }
        var sortedDict = from entry in freq orderby entry.Value descending select entry;
        int[] f = new int[k];

        for (int i = 0; i < k; i++)
        {
            f[i] = sortedDict.ElementAt(i).Key;
        }
        return f;
    }
}