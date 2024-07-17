namespace Plus_Minus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = [-4, 3, -9, 0, 4, 1];
            plusMinus(nums);
            
        }
        public static void plusMinus(List<int> arr)
        {
            decimal positive = 0;
            decimal negative = 0;
            decimal zero = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0) 
                {
                    positive++;
                }
                else if (arr[i] < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }
            Console.WriteLine((positive / arr.Count).ToString("F6"));
            Console.WriteLine((negative / arr.Count).ToString("F6"));
            Console.WriteLine((zero / arr.Count).ToString("F6"));
        }
    }
}
