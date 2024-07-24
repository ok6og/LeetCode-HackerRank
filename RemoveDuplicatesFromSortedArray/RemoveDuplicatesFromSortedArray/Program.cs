namespace RemoveDuplicatesFromSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]));
        }

        public static int RemoveDuplicates(int[] nums)
        {
            SortedSet<int> result = [.. nums];
            int i = 0;
            foreach (var num in result)
            {
                nums[i++] = num;
            }
            return result.Count;
        }
    }
}
