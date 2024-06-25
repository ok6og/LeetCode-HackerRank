namespace DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>
            {
                //new List<int> {3},
                new List<int> { 11, 2, 4 },
                new List<int> { 4, 5, 6 },
                new List<int> { 10, 8, -12 }
            };

            Console.WriteLine(diagonalDifference(arr));
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                
                sum1 += arr[i][i];
                sum2 += arr[i][(arr.Count - i -1)];

            }

            return Math.Abs(sum1 - sum2);
        }
    }
}
