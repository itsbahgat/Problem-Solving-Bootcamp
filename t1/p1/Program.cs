// See https://aka.ms/new-console-template for more information
using System.Globalization;

int[] arr;
arr = new int[] { 1, 2, 3, 4 };
Console.WriteLine(ContainsDuplicate(arr));

#region case1
//bool ContainsDuplicate(int[] nums)
//{
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (Array.Exists(nums[(i + 1)..], element => element == nums[i]) == true)
//        {
//            return true;
//        }
//    }
//        return false;

//}
#endregion

#region case2
//bool ContainsDuplicate(int[] nums)
//{
//    for (int i = 0; i < nums.Length; i++)
//    {
//        for (int j = nums.Length-1; j > i; j--)
//        {
//            if (nums[j] == nums[i])
//            {
//                return true;
//            }
//        }
//    }
//    return false;
//}
#endregion

#region case3
//bool ContainsDuplicate(int[] nums)
//{
//    return nums.Distinct().Count() != nums.Length;
//}
#endregion

#region case4
bool ContainsDuplicate(int[] nums)
{
    //return nums.Distinct().Count() != nums.Length;
var check = nums.Intersect(nums);

if (check.Count() == nums.Count() || check.Count() == 0)
{
    return false;
}

return true;
}
#endregion
