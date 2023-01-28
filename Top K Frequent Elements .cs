public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
                        IList<int> arrRes = new List<int>();
                Dictionary<int , int> myDict  = new Dictionary<int , int>();
                int freq = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    freq = nums[i];
                    if (myDict.ContainsKey(freq))
                    {
                        myDict[freq] +=1;
                    }
                    else
                    {
                        myDict.Add(freq, 1);
                    }
                }
                
                var selected = myDict.OrderByDescending(x => x.Value).Take(k);

                foreach (var x in selected)
                {
                    arrRes.Add(x.Key);
                }
                return arrRes.ToArray();
    }
}
