using System;
namespace ArraysQuestions
{
    /*
     * You are given an array of n integers which can contain integers from 1 to n only.
     * Some elements can be repeated multiple times and some other elements can be absent from the array.
     * Write a running code on paper which takes O(1) space apart from the input array 
     * and O(n) time to print which elements are not present in the array 
     * and the count of every element which is there in the array along with the element number.
     * http://ms-amazon.blogspot.ru/2013/07/you-are-given-array-of-n-integers-which.html
     */
    public class Task01
    {
        /*         
        First Let's see what all approaches we can take and then we check if it fits our requirement. 
 
        1.  Brute Force: Select an element from 1 to N and check it frequency of occurrence. But this will be O(n2) and not O(n). 
        2.  XOR: but this technique won't work as question mentions an element can be repeated multiple times.
            So if element repeats 2 times or 4 times each time result of xor will be 0 so we cannot get the frequency of
            occurrences. 
        3.  HashMap: We can create a HashMap in O(n) key will be elements and value will be their frequency of occurrence.
            But since we have to do it in O(1) space we cannot take this approach. 
 
        So we cannot opt for any of the above 3 approach. We have to check for some 4th approach. 
        Since we have range of numbers given to us we have to think in those lines. 
        Array Index is from 0 to N-1 and range is from 1 to N. Can't we use the array as hash itself? 
        where array "Index-1" represents the key (element) and value stored at index will represent the "frequency of occurrence". 
 
        But how will we take care that an element present at any index is not overwritten as this can cause problem? 
        We can sort the array in that case value present at index i is I+1 itself. 
 
        What is the complexity of sorting the array? 
        Since the range of element is given to us we can sort it in O(n).
 
        ALGORITHM
        Since array contains elements from 1 to N we cannot keep frequency in same array as it will confuse which one is 
        frequency and which one is the element value.
        To overcome this, store frequency in negative, -1 = element appear once and so on, by this we are able to distinguish 
        between frequency of occurrence and elements.
        Negative values/0 are frequency and +ve values are elements.
 
        1. Scan array from left to right.
                Pos =0 ; while pos < N
        2. If current element is –ve or 0 then move forward (pos++).
        3. Desiredpos = arr[pos]-1.
        4. Check if arr[desiredPos] > 0
            a.  If yes that means no previous occurrence of current element. 
                Hence copy arr[pos] = arr[desiredPos] and set arr[desiredPos] =-1 i.e. first occurrence.
            b.  Else if it is encountered earlier also then decrement the frequency (arr[desiredPos]--) and set arr[pos] =0.
        5. While displaying frequency multiply the elements with -1, as all elements in array will be either –ve or 0.
        */
        public static void Do(int[] arr)
        {
            int pos = 0;
            int desiredPos = 0;

            while (pos < arr.Length)
            {
                if (arr[pos] <= 0)
                {
                    pos++;
                    continue;
                }

                desiredPos = arr[pos] - 1;

                if (arr[desiredPos] > 0)
                {
                    arr[pos] = arr[desiredPos];
                    arr[desiredPos] = -1;
                }
                else
                {
                    arr[desiredPos]--;
                    arr[pos] = 0;
                    pos++;
                }
            }
        }

        public static void Display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) System.Console.WriteLine("\nElement = " + (i + 1) + "\tFrequency = " + arr[i] * -1);
        }
    }
}
