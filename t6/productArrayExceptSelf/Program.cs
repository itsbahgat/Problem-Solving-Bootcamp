// See https://aka.ms/new-console-template for more information

int[] nums = { 1, 2, 3, 4 };
int[] arr = ProductExceptSelf(nums);
for(int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

int[] ProductExceptSelf(int[] nums)
{
    int[] Product = new int[nums.Length];
    int multi = 1, flag = 0, zeros = 0;
    for(int i =0; i<nums.Length; i++)
    {
        if (nums[i] == 0)
        {
            zeros++;
            flag= 1;
            continue;
        }
        else
        {
            multi*= nums[i];
        }
    }
    for(int j=0; j<nums.Length; j++)
    {
        if (zeros >=2)
            return new int[nums.Length];
        else if(nums[j] == 0)
            Product[j] = multi;
        else if (nums[j] != 0 && flag==1)
            Product[j] = 0;
        else
            Product[j] = multi / nums[j];
    }
    return Product;
}
