using System.Drawing;

namespace Contains_Duplicate
{
    internal class Program
    { 
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> unique = new HashSet<int>(nums);
            return nums.Length > unique.Count;
        }
    
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter size of array");
            size = Int32.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Enter elment of an array");
            for(int i = 0; i < size; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine(ContainsDuplicate(arr));
        }
    }
}
