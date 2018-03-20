using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysQuestions
{
    /*
     * Find All Numbers Disappeared in an Array
     * 
     * Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
     * Find all the elements of [1, n] inclusive that do not appear in this array.
     * Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
     * 
     * Example:
     * Input:
     * [4,3,2,7,8,2,3,1]
     * Output:
     * [5,6]
     * 
     * https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
     */
    public class Task22FindAllNumbersDisappeared
    {
        public static IList<int> Do(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                var val = Math.Abs(nums[i]) - 1;

                if (nums[val] > 0)
                {
                    nums[val] = -nums[val];
                }
            }

            var ret = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) ret.Add(i + 1);
            }

            return ret;
        }
    }
}
