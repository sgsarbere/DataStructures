using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BestTimeToBuyStock
    {
        public int MaxProfit(int[] prices)
        {

            int buyValue = prices[0];

            int buyIndex = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (buyValue >= prices[i])
                {
                    buyValue = prices[i];
                    buyIndex = i;
                }
            }
            if (buyIndex == prices.Length - 1)
                return 0;
            int sellValue = prices[buyIndex];
            int sellIndex = buyIndex;
            for (int i = buyIndex; i < prices.Length; i++)
            {
                if (sellValue <= prices[i])
                {
                    sellValue = prices[i];
                    sellIndex = i;
                }
            }

            return sellValue - buyValue;
        }

        public int MaxProfitWay2(int[] prices)
        {

            int buyValue = prices[0];

            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (buyValue >= prices[i])
                {
                    buyValue = prices[i];
                }
                if (profit < (prices[i] - buyValue))
                    profit = prices[i] - buyValue;
            }


            return profit;
        }
    }
}
//Best Time to Buy and Sell Stock
//Easy
//22.4K
//705
//Companies
//You are given an array prices where prices[i] is the price of a given stock on the ith day.

//You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

//Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.




//Example 1:

//Input: prices = [7, 1, 5, 3, 6, 4]
//Output: 5
//Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
//Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
//Example 2:

//Input: prices = [7,6,4,3,1]
//Output: 0
//Explanation: In this case, no transactions are done and the max profit = 0.


//Constraints:

//1 <= prices.length <= 105
//0 <= prices[i] <= 104