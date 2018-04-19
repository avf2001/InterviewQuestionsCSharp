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
            //var task08Result = ArraysQuestions.Task08PlusOne.Do(new int[] { 9, 8, 9 });

            // Pascal's Triangle            
            //var task10Result = ArraysQuestions.Task10PascalsTriangle.Do(5);

            /*
            foreach (var a in task10Result)
            {
                Console.Write("[");

                var separator = "";

                foreach (var b in a)
                {
                    Console.Write(separator + b);

                    separator = ", ";
                }

                Console.WriteLine("]");
            }
            */

            // Pascal's Triangle 2
            var task11Result = ArraysQuestions.Task11PascalsTriangle2.Do(4);

            // Best Time to Buy and Sell Stock
            var task12Result = ArraysQuestions.Task12BestTimeToBuyAndSellStock.Do(new int[] { 7, 1, 5, 3, 6, 4 }); // 5
            task12Result = ArraysQuestions.Task12BestTimeToBuyAndSellStock.Do(new int[] { 7, 6, 4, 3, 1 }); // 0
            task12Result = ArraysQuestions.Task12BestTimeToBuyAndSellStock.Do(new int[] { }); // 0
            task12Result = ArraysQuestions.Task12BestTimeToBuyAndSellStock.Do(new int[] { 1 }); // 0
            task12Result = ArraysQuestions.Task12BestTimeToBuyAndSellStock.Do(new int[] { 2, 4, 1 }); // 2

            // Best Time to Buy and Sell Stock 2
            var task13Result = ArraysQuestions.Task13BestTimeToBuyAndSellStock2.Do(new int[] { 7, 1, 5, 3, 6, 4 }); // 7
            task13Result = ArraysQuestions.Task13BestTimeToBuyAndSellStock2.Do(new int[] { 7, 6, 4, 3, 1 }); // 0
            task13Result = ArraysQuestions.Task13BestTimeToBuyAndSellStock2.Do(new int[] { }); // 0
            task13Result = ArraysQuestions.Task13BestTimeToBuyAndSellStock2.Do(new int[] { 1 }); // 0
            task13Result = ArraysQuestions.Task13BestTimeToBuyAndSellStock2.Do(new int[] { 2, 4, 1 }); // 2

            // Two Sum 2
            var task14Result = ArraysQuestions.Task14TwoSum2.Do(new int[] { 2, 7, 11, 15 }, 9);
            task14Result = ArraysQuestions.Task14TwoSum2.Do2(new int[] { 2, 7, 11, 15 }, 9);

            // Majoruty Element
            var task15Result = ArraysQuestions.Task15MajorityElement.Do(new int[] { 2, 7, 11, 15 });

            var task19Result = ArraysQuestions.Task19MissingNumber.Do(new int[] { 3, 0, 1 });

            var task20InputArray = new int[] { 0, 1, 0, 3, 12 };            
            ArraysQuestions.Task20MoveZeroes.Do(task20InputArray);

            #region Sorting Algorithms

            // Bubble Sort
            //BubbleSort.Do1(arr);

            // Insertion Sort
            //InsertionSort.Do(arr);

            // Counting Sort
            //CountingSort.Do(ref arr);

            #endregion

            #region Maths Questions

            // Не решено
            //var mtask01Result = MathsQuestions.Task01A3B3C3D3.Do(1000);

            #endregion

            var stask02Result1 = StringQuestions.Task02CheckPermutation.Do1("aabbbb", "bbbaaa");
            var stask02Result2 = StringQuestions.Task02CheckPermutation.Do2("aaabbb", "bbbaaa");
        }
    }
}
