namespace BestTimeToBuyAndSellAStock_LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxProfit([7, 1, 5, 3, 6, 4]));
        }

        public static int MaxProfit(int[] prices)
        {
            int cashMoneyMade = 0;
            int minPrice = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > cashMoneyMade)
                {
                    cashMoneyMade = prices[i] - minPrice;
                }
            }
            return cashMoneyMade;
        }
    }
}
