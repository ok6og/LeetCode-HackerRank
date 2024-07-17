namespace _1WeekPreperationKit_Find_The_Median
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findMedian([0, 1, 2, 4, 6, 5, 3]));
        }

        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            return arr[arr.Count / 2];
        }
    }
}
