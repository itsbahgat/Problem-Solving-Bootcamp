 public static int LongestConsecutive(int[] nums)
            {
                
                int coun = 0, max = 0;
                if (nums.Length == 0) return max;

                HashSet<int> set = new HashSet<int>(nums);
                nums = set.ToArray();

                Array.Sort(nums);

                for (int i= 0;i < nums.Length-1;i++)
                {
                    //Console.Write(nums[i]);
                    if (Math.Abs(nums[i] - nums[i + 1]) == 1)
                    {
                        
                        ++coun;
                       
                    }
                    else
                    {
                        coun = 0;
                    }
                    if (coun > max) max = coun;
                }
                return max+1;
                

            }
