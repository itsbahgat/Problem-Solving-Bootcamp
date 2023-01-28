// See https://aka.ms/new-console-template for more information

int[] nums = { 1, 1, 1, 2, 2, 3 }; 
int k = 1;
int[] res;
res = new int[k];
res= TopKFrequent(nums, k);
for  (int i =0; i<k; i++)
{
    Console.WriteLine(res[i]);
}

int[] TopKFrequent(int[] nums, int k)
{
    Dictionary<int, int> frequentElement =new();
    for (int i = 0; i < nums.Length; i++)
    {
        if (!frequentElement.ContainsKey(nums[i]))
            frequentElement.Add(nums[i], 1);
        else
            frequentElement[nums[i]]++;
    }
    frequentElement = frequentElement.OrderBy(key => key.Value).ToDictionary(i => i.Key, i => i.Value);

    return frequentElement.Keys.ToArray()[^k..];
}
