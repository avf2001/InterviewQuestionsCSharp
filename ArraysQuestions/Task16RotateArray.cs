using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysQuestions
{
    /*
     * Rotate an array of n elements to the right by k steps.
     * For example, with n = 7 and k = 3, the array [1,2,3,4,5,6,7] is rotated to [5,6,7,1,2,3,4].
     * Note: Try to come up as many solutions as you can, there are at least 3 different ways to solve this problem.
     * 
     * https://leetcode.com/problems/rotate-array/description/
     */
    public class Task16RotateArray
    {
        public static void Do(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0) return;

            int currIdx = 0;
            int currVal = nums[0];
            int circle = 0;

            for (int i = 0; i < nums.Length; ++i)
            {
                int nextIdx = (currIdx + k) % nums.Length;
                int temp = nums[nextIdx];
                nums[nextIdx] = currVal;

                currIdx = nextIdx;
                currVal = temp;

                circle = (circle + k) % nums.Length;

                if (circle == 0)
                {
                    currIdx = (currIdx + 1) % nums.Length;
                    currVal = nums[currIdx];
                }
            }
        }
    }
}
