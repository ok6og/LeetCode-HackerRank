namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProfit([7, 6, 4, 3, 1]));
        }

        public static int MaxProfit(int[] prices)
        {
            int left = 0;
            int right = 0;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length-1; i++)
            {
                right++;
                if (prices[left] < prices[right])
                {
                    maxProfit = Math.Max(maxProfit, prices[right] - prices[left]);
                }
                else if(prices[left] > prices[right])
                {
                    left = right;
                }
            }
            return maxProfit;
        }
    }
}
