namespace AppleAndOragne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            countApplesAndOranges(7, 11, 5, 15, [-2, 2, 1], [5, -6]);
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int startOfSamHouse = s;
            int endOfSamHouse = t;
            int appleTreePosition = a;
            int orangeTreePosition = b;

            int numOfApplesOnSamHouse = apples.Select(x => appleTreePosition + x).Count(x=> x >= startOfSamHouse && x <= endOfSamHouse);
            int numOfOrangesOnSamHouse = oranges.Select(x => orangeTreePosition + x).Count(x => x >= startOfSamHouse && x <= endOfSamHouse);

            Console.WriteLine(numOfApplesOnSamHouse);
            Console.WriteLine(numOfOrangesOnSamHouse);
        }
    }
}
