namespace ArraysQuestions
{
    /*
     * Maximum Subarray (Kadane's algorithm)
     * 
     * Given an integer array nums, find the contiguous subarray (containing at least one number)
     * which has the largest sum and return its sum.
     * 
     * Example:
     * Input: [-2,1,-3,4,-1,2,1,-5,4],
     * Output: 6
     * Explanation: [4,-1,2,1] has the largest sum = 6.
     * 
     * https://leetcode.com/problems/maximum-subarray/description/
     */
    public class Task07MaximumSubarray
    {
        /*
         * https://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
         */
        public static int Do(int[] nums)
        {
            int[] dp = new int[nums.Length];
            dp[0] = nums[0];
            int max = dp[0];

            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = nums[i] + (dp[i - 1] > 0 ? dp[i - 1] : 0);
                max = System.Math.Max(max, dp[i]);
            }

            return max;
        }
    }
}
