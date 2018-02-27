namespace ArraysQuestions
{
    /*
     * Best Time to Buy and Sell Stock II
     * 
     * Say you have an array for which the ith element is the price of a given stock on day i.
     * Design an algorithm to find the maximum profit.
     * You may complete as many transactions as you like (ie, buy one and sell one share of the stock multiple times).
     * However, you may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
     * 
     * https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
     */
    public class Task13BestTimeToBuyAndSellStock2
    {
        public static int Do(int[] prices)
        {
            if (prices.Length < 2) return 0;

            var cur = prices[0];
            var sum = 0;

            for (var i = 1; i < prices.Length; i++)
            {
                if (cur < prices[i]) sum += prices[i] - cur;
                cur = prices[i];
            }

            return sum;
        }
    }
}
