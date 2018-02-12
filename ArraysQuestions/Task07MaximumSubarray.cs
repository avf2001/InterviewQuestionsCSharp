﻿namespace ArraysQuestions
{
    public class Task07MaximumSubarray
    {
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
