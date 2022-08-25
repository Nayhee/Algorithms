using System;
using System.Linq;

namespace BuySellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxProfit(int[] prices)
            {
                var profit = 0;
                var maxProfit = 0;

                if(prices == null || prices.Length == 0)
                {
                    return profit;
                }

                int buyPrice = prices[0];
                int sp = 0;

                for(int i = 1; i < prices.Length; i++)
                {
                    if (prices[i] <= buyPrice)
                    {
                        buyPrice = prices[i];
                        sp = 0;
                    }
                    else if (prices[i] >= sp)
                    {
                        sp = prices[i];
                        profit = sp - buyPrice;
                        maxProfit = Math.Max(profit, maxProfit);
                    }
                }
                return maxProfit;
            }

            var prices = new int[3] { 2, 4, 1 };
            Console.WriteLine(MaxProfit(prices));
        }
    }
}
