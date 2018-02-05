namespace ArraysQuestions
{
    public class Task04RemoveDuplicatesFromSortedArray
    {
        public static int Do(int[] array)
        {
            if (array.Length <= 1) return array.Length;

            var j = 0;

            
            for (var i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i+1])
                {
                    array[j] = array[i];
                    j++;
                }
            }            

            array[j++] = array[array.Length - 1];

            return j;
        }
    }
}
