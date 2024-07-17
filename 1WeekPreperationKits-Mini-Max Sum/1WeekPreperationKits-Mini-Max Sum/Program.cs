using System.Numerics;

namespace _1WeekPreperationKits_Mini_Max_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = [256741038, 623958417, 467905213, 714532089, 938071625];
            miniMaxSum(list);
        }

        public static void miniMaxSum(List<int> arr)
        {
            List<long> ordered = arr.Order().Select(x => (long)x).ToList();

            long min = ordered.Take(4).Sum();
            long max = ordered.TakeLast(4).Sum();

            Console.WriteLine(min + " " + max);
        }
    }
}
