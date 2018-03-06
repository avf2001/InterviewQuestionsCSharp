using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysQuestions
{
    /*
     * Contains Duplicate
     * 
     * Given an array of integers, find if the array contains any duplicates.
     * Your function should return true if any value appears at least twice in the array, 
     * and it should return false if every element is distinct.
     * 
     * https://leetcode.com/problems/contains-duplicate/description/
     */
    public class Task17ContainsDuplicate
    {
        public static bool Do(int[] nums)
        {            
            var hash = new HashSet<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (hash.Contains(nums[i])) return true;

                hash.Add(nums[i]);
            }

            return false;
        }
    }
}
