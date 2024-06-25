namespace Mini_Max_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = [256741038, 623958417, 467905213, 714532089, 938071625];
            miniMaxSum(ints);
        }

        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            Console.WriteLine($"{arr.Take(4).Sum(item=> (long)item)} {arr.TakeLast(4).Sum(item => (long)item)}");
        }
    }
}
