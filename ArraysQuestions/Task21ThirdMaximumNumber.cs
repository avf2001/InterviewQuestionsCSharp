﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysQuestions
{
    /*
     * Third Maximum Number
     * 
     * Given a non-empty array of integers, return the third maximum number in this array.
     * If it does not exist, return the maximum number. The time complexity must be in O(n).
     * 
     * Example 1:
     * Input: [3, 2, 1]
     * Output: 1
     * Explanation: The third maximum is 1.
     * 
     * Example 2:
     * Input: [1, 2]
     * Output: 2
     * Explanation: The third maximum does not exist, so the maximum (2) is returned instead.
     * 
     * Example 3:
     * Input: [2, 2, 3, 1]
     * Output: 1
     * Explanation: Note that the third maximum here means the third maximum distinct number.
     * Both numbers with value 2 are both considered as second maximum.
     * 
     * https://leetcode.com/problems/third-maximum-number/description/
     */
    public class Task21ThirdMaximumNumber
    {
        public static int Do(int[] nums)
        {
            int? max1 = null;
            int? max2 = null;
            int? max3 = null;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max1 || nums[i] == max2 || nums[i] == max3) continue;

                if (!max1.HasValue || nums[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (!max2.HasValue || nums[i] > max2)
                {
                    max3 = max2;
                    max2 = nums[i];
                }
                else if (!max3.HasValue || nums[i] > max3)
                {
                    max3 = nums[i];
                }
            }

            return max3.HasValue ? max3.Value : max1.Value;
        }        
    }
}
