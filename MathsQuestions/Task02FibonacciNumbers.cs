namespace MathsQuestions
{
    public class Task02FibonacciNumbers
    {
        /*
         * This gives us a runtime of roughly O(2^n).
         */
        public static int DoRecursion(int i)
        {
            if (i == 0) return 0;
            if (i == 1) return 1;
            return DoRecursion(i - 1) + DoRecursion(i - 2);
        }

        /*
         * This gives us a runtime of O(n).
         */
        public static int DoDynamic(int i)
        {
            return DoDynamic(i, new int[i + 1]);
        }

        static int DoDynamic(int i, int[] memo)
        {
            if (i == 0 || i == 1) return i;
            
            if (memo[i] == 0)
            {
                memo[i] = DoDynamic(i - 1, memo) + DoDynamic(i - 2, memo);
            }

            return memo[i];
        }
    }
}
