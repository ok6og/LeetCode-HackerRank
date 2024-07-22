namespace BestTimeToBuyAStock_NeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = [7, 1, 5, 3, 0, 4];
            Console.WriteLine(MaxProfit(prices));
        }

        public static int MaxProfit(int[] prices)
        {
            int pointerLeftBuy = 0;
            int pointerRightSell = 1;
            int maxProfit = 0;

            while(pointerRightSell < prices.Length)
            {
                if (prices[pointerLeftBuy] < prices[pointerRightSell])
                {
                    int profit = prices[pointerRightSell] - prices[pointerLeftBuy];
                    maxProfit = int.Max(maxProfit, profit);
                }
                else
                {
                   pointerLeftBuy = pointerRightSell;
                }
                pointerRightSell++;

                
            }
            return maxProfit;

        }
    }
}
