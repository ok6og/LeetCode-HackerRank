namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Search([-1, 0, 3, 5, 9, 12], 12));
        }


        public static int Search(int[] nums, int target)
        {

            int low = 0;
            int high = nums.Length;


            do
            {
                int middle = low + (high - low) / 2;
                int v = nums[middle];

                if (v == target)
                {
                    return middle;
                }
                else if (v > target)
                {
                    high = middle;
                }
                else if (v < target)
                {
                    low = middle+1;
                }

            } while (low < high);

            return -1;

        }
    }
}
