namespace SortingAlgorithms
{
    public class BubbleSort
    {
        public static void Do1(int[] array)
        {
            var swapped = false;

            do
            {
                swapped = false;

                for (var i = 1; i < array.Length; i++)
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
