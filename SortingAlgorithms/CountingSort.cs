namespace SortingAlgorithms
{
    /*
     * https://www.geeksforgeeks.org/counting-sort/
     */
    public class CountingSort
    {
        public static void Do(ref int[] array)
        {
            int n = array.Length;

            // The output character array that will have sorted arr
            var output = new int[n];

            var maxValue = array[0];

            for (var i = 1; i < n; i++)
            {
                if (array[i] > maxValue) maxValue = array[i];
            }

            // Create a count array to store count of inidividul
            // characters and initialize count  array as 0
            var count = new int[maxValue + 1];            

            // store count of each character
            for (int i = 0; i < n; ++i)
                ++count[array[i]];

            // Change count[i] so that count[i] now contains actual
            // position of this character in output array
            for (int i = 1; i <= maxValue; i++)
                count[i] += count[i - 1];

            // Build the output character array
            for (int i = 0; i < n; ++i)
            {
                output[count[array[i]] - 1] = array[i];
                --count[array[i]];
            }

            // Copy the output array to arr, so that arr now
            // contains sorted characters            
            array = output;
        }
    }
}
