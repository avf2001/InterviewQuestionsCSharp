using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysQuestions
{
    public class Task05RemoveElement
    {
        public static int Do(int[] array, int value)
        {
            var originalLength = array.Length;
            var count = 0;

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    count++;
                }
                else {
                    array[i - count] = array[i];
                }
            }

            return originalLength - count;
        }
    }
}
