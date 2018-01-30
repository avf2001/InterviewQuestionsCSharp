using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class BubbleSort
    {
        public static void Do(int[] array)
        {
            var n = array.Length;
            var swapped = false;

            do
            {
                swapped = false;

                for (var i = 1; i < n; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        var temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                        swapped = true;
                    }
                }
                
            } while (swapped);   
        }
    }
}
