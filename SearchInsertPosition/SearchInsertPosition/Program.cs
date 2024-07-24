namespace SearchInsertPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SearchInsert([1, 3, 5, 6], 5));
        }
        public static int SearchInsert(int[] nums, int target)
        {
            int jmpAmount = (int)Math.Floor(Math.Sqrt(nums.Length));
            int i = 0;

            while (i < nums.Length && nums[i] < target)
            {
                i += jmpAmount;
            }

            for (int j = Math.Max(0, i - jmpAmount); j < nums.Length && j <= i; j++)
            {
                if (nums[j] >= target)
                {
                    return j;
                }
            }
            return nums.Length;

            //if (target < nums[0])
            //{
            //    return 0;
            //}

            //for (; i < nums.Length; i += jmpAmount)
            //{
            //    if (nums[i]>= target)
            //    {
            //        break;
            //    }
            //}
            //i -= jmpAmount;


            //for (int j = 0; j < jmpAmount && i < nums.Length; j++, i++)
            //{
            //    if (nums[i] >= target)
            //    {
            //        return i;
            //    }
            //}

            //for (int j = 0; j < jmpAmount; j++, i++)
            //{
            //    if (target == 0 && nums[0] > 0)
            //    {
            //        return 0;
            //    }
            //    if (nums[i] == target)
            //    {
            //        return i;
            //    }
            //    else if (i < nums.Length - 1 && nums[i] < target && nums[i + 1] > target)
            //    {
            //        return i+1;
            //    }
            //}

            //return nums.Length; 
        }
    }
}
