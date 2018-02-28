using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysQuestions
{
    /*
     * Given an array of integers that is already sorted in ascending order, 
     * find two numbers such that they add up to a specific target number.
     * The function twoSum should return indices of the two numbers such that they add up to the target,
     * where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.
     * You may assume that each input would have exactly one solution and you may not use the same element twice.
     * 
     * https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
     */
    public class Task14TwoSum2
    {
        public static int[] Do(int[] numbers, int target)
        {
            var index1 = -1;
            var index2 = -1;
            var completed = false;

            for (var i = 1; i <= numbers.Length; i++)
            {
                index1 = i;

                for (var j = i + 1; j <= numbers.Length; j++)
                {
                    if (numbers[index1 - 1] + numbers[j - 1] == target)
                    {
                        index2 = j;
                        completed = true;
                        break;
                    }
                    else if (numbers[index1 - 1] + numbers[j - 1] > target)
                    {
                        break;
                    }
                }

                if (completed) break;
            }

            return new int[] { index1, index2 };
        }

        public static int[] Do2(int[] numbers, int target)
        {
            var index1 = 1;
            var index2 = numbers.Length;

            while (index1 < index2)
            {
                var difference = target - (numbers[index1 - 1] + numbers[index2 - 1]);
                
                if (difference > 0)
                {
                    index1++;
                }
                else if (difference < 0)
                {
                    index2--;
                }
                else
                {
                    break;
                }
            }

            return new int[] { index1, index2 };
        }
    }
}
