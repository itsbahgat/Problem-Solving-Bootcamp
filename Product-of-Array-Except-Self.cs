public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

            int [] product  = new int[nums.Length];

            product[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                product[i] = nums[i-1] * product[i-1];
            }
            int suffix = 1;

            for (int i = nums.Length-1; i >=0; i--)
            {
                product[i] = product[i] * suffix;
                suffix = suffix * nums[i];

            }

            return product;
    }
}
