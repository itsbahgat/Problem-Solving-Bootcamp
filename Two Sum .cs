int[] TwoSum(int[] nums, int target)
{
  int[] res= new int[2];
  int i , j;
  for (i = 0; i < nums.Length ; i++)
  {
      for (j = i+1; j < nums.Length ; j++)
      {
          if (nums[i] + nums[j] == target)
          {
              res[0] = i;
              res[1] = j;
              return res;
          }
      }
  }
  return res;
}
