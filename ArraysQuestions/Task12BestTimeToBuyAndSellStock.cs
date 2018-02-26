namespace ArraysQuestions
{
    /* Best Time to Buy and Sell Stock
     * 
     * Say you have an array for which the ith element is the price of a given stock on day i.
     * If you were only permitted to complete at most one transaction (ie, buy one and sell one share of the stock),
     * design an algorithm to find the maximum profit.
     * 
     * Example 1:
     * Input: [7, 1, 5, 3, 6, 4]
     * Output: 5
     * max. difference = 6-1 = 5 (not 7-1 = 6, as selling price needs to be larger than buying price)
     * 
     * Example 2:
     * Input: [7, 6, 4, 3, 1]
     * Output: 0
     * In this case, no transaction is done, i.e. max profit = 0.
     * 
     * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
     */
    public class Task12BestTimeToBuyAndSellStock
    {
        /*
         * To solve this problem efficiently, you would need to track the minimum value’s index.
         * As you traverse, update the minimum value’s index when a new minimum is met.
         * Then, compare the difference of the current element with the minimum value.
         * Save the buy and sell time when the difference exceeds our maximum difference (also update the maximum difference).
         */
        public static int Do(int[] prices)
        {
            int min = 0;
            int maxDiff = 0;
            int buy = 0;
            int sell = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < prices[min]) min = i;

                int diff = prices[i] - prices[min];

                if (diff > maxDiff)
                {
                    buy = min;
                    sell = i;
                    maxDiff = diff;
                }
            }

            return maxDiff;
        }
    }
}
