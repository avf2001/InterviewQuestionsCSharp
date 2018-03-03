using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysQuestions
{
    /*
     * Majority Element
     * 
     * Given an array of size n, find the majority element. The majority element is the element that appears more than n/2 times.
     * You may assume that the array is non-empty and the majority element always exist in the array.
     * 
     * https://leetcode.com/problems/majority-element/description/
     */
    public class Task15MajorityElement
    {
        public static int Do(int[] nums)
        {
            var majority = nums[0];
            var count = 1;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] == majority)
                {
                    count++;
                }
                else
                {
                    if (count > 0)
                    {
                        count--;
                    }
                    else
                    {
                        majority = nums[i];
                        count = 1;
                    }
                }
            }

            return majority;
        }
    }
}
