namespace PlusMinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr1 = [-4, 3, -9, 0, 4, 1];
            plusMinus(arr1);
        }

        public static void plusMinus(List<int> arr)
        {
            double positive = 0;
            double negative = 0;
            double isZero = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 0)
                {
                    isZero++;
                }
                else if (arr[i] > 0)
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
            }

            Console.WriteLine((positive / arr.Count).ToString("F6"));
            Console.WriteLine((negative / arr.Count).ToString("F6"));
            Console.WriteLine((isZero / arr.Count).ToString("F6"));

        }
    }
}
