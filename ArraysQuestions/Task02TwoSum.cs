using System;
using System.Collections.Generic;

namespace ArraysQuestions
{
    public class Task02TwoSum
    {
        public static int[] Do(int[] arr, int target)
        {
            var map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int complement = target - arr[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                map[arr[i]] = i;
            }            

            return new int[] { -1, -1 }; // Nothing found
        }
    }
}
