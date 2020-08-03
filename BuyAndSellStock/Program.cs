using System;

namespace BuyAndSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 2, 4, 1 };
            Console.WriteLine(MaxProfit(prices));
        }

        /// <summary>
        /// Pavan Didn't come thru this soln. This is a DP. Need to get better at Identifying DP Pattern
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            int profit = 0, minPrice = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                    minPrice = prices[i];
                else if (prices[i] - minPrice > profit)
                    profit = prices[i] - minPrice;
            }
            return profit;
        }
    }
}
