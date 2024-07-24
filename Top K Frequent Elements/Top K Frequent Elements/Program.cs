namespace Top_K_Frequent_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(',',TopKFrequent([1, 1, 1, 2, 2, 3],2)));
        }

        public static int[] TopKFrequent(int[] nums, int k)
        {
            return nums.GroupBy(x=>x).ToDictionary(x => x.Key, x => x.Count()).OrderByDescending(x => x.Value).Take(k).Select(x=> x.Key).ToArray();
        }
    }
}
