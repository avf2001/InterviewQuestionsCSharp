using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysQuestions
{
    public class Task20MoveZeroes
    {
        /*
         * Move Zeroes
         * 
         * Given an array nums, write a function to move all 0's to the end 
         * of it while maintaining the relative order of the non-zero elements.
         * For example, given nums = [0, 1, 0, 3, 12], after calling your function, nums should be [1, 3, 12, 0, 0].
         * Note:
         * You must do this in-place without making a copy of the array.
         * Minimize the total number of operations.
         * 
         * https://leetcode.com/problems/move-zeroes/description/
         */
        public static void Do(int[] nums)
        {
            var shift = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    shift++;
                else
                    nums[i - shift] = nums[i];
            }

            for (var i = nums.Length - shift; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
