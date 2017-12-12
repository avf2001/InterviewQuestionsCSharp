using System;
using System.Collections.Generic;

namespace ArraysQuestions
{
    public class Task02
    {
        public static int[] Do(int[] arr)
        {
            var hm = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {

                if (20 % arr[i] == 0 && hm.ContainsKey(20 / arr[i]))
                {
                    return new int[] { hm[20 / arr[i]], i };
                }

                hm[arr[i]] = i;
            }

            return new int[] { -1, -1 }; // Nothing found
        }
    }
}
