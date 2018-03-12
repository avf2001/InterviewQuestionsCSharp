using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysQuestions
{
    /*
     * Contains Duplicate II
     * 
     * Given an array of integers and an integer k, 
     * find out whether there are two distinct indices i and j in the array such that nums[i] = nums[j] and 
     * the absolute difference between i and j is at most k.
     * 
     * https://leetcode.com/problems/contains-duplicate-ii
     */
    public class Task18ContainsDuplicate2
    {
        public static bool Do(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    if (i - dict[nums[i]] <= k)
                        return true;
                    else
                        dict[nums[i]] = i;
                }
                else
                    dict.Add(nums[i], i);
            }

            return false;
        }
    }
}
