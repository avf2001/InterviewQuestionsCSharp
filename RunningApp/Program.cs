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

            // Two Sum
            //var task02Result = ArraysQuestions.Task02TwoSum.Do(arr, 11);

            // Container With Most Water
            //var task03Result = ArraysQuestions.Task03ContainerWithMostWater.Do(arr);

            // Remove Duplicates from Sorted Array
            //int[] task04Array = { 1, 1, 2, 2, 2, 3, 4, 5, 5, 6, 6, 6, 6 };
            //var newSize = ArraysQuestions.Task04RemoveDuplicatesFromSortedArray.Do(task04Array);

            // Remove Element
            //int[] task05Array = { 3, 2, 2, 3 };
            //var task05NewSize = ArraysQuestions.Task05RemoveElement.Do(task05Array, 3);

            // Search Insert Position
            //var task06Result = ArraysQuestions.Task06SearchInsertPosition.Do(new int[] { 1 }, 1);

            // Plus One
            var task08Result = ArraysQuestions.Task08PlusOne.Do(new int[] { 9, 8, 9 });

            #region Sorting Algorithms

            // Bubble Sort
            //BubbleSort.Do1(arr);

            // Insertion Sort
            //InsertionSort.Do(arr);

            // Counting Sort
            //CountingSort.Do(ref arr);

            #endregion
        }
    }
}
