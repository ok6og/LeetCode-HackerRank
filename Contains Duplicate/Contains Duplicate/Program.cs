using System.Runtime.CompilerServices;

namespace Contains_Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]));
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i+1; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            return true;
            //        }
            //    }
            //}
            //return false;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                set.Add(nums[i]);
            }
            return false;
        }
    }
}
