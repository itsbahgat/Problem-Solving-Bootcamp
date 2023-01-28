public static int[] TopKFrequent(int[] nums, int k)
{

	Dictionary<int, int> dic = new Dictionary<int, int>();

	for (int i = 0; i < nums.Length; i++)
	{
		if (dic.ContainsKey(nums[i]))
			dic[nums[i]]++;
		else
			dic[nums[i]] = 1;
	}
	dic = dic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
	return dic.Keys.ToArray()[..k];

}