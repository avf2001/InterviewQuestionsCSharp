using SortingAlgorithms;
using System;

namespace RunningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 4, 1, 4, 3, 2, 5, 2, 1 };

            /*
            ArraysQuestions.Task01.Display(arr);
            ArraysQuestions.Task01.Do(arr);
            ArraysQuestions.Task01.Display(arr);
            */

            //var task02Result = ArraysQuestions.Task02.Do(arr);

            #region Sorting Algorithms

            // Bubble Sort
            //BubbleSort.Do1(arr);

            // Insertion Sort
            //InsertionSort.Do(arr);

            // Counting Sort
            CountingSort.Do(ref arr);

            #endregion
        }
    }
}
