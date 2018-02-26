using System.Collections.Generic;

namespace ArraysQuestions
{
    /*
     * Given an index k, return the kth row of the Pascal's triangle.
     * For example, given k = 3,
     * Return [1,3,3,1].
     * Note:
     * Could you optimize your algorithm to use only O(k) extra space?
     * 
     * https://leetcode.com/problems/pascals-triangle-ii/description/
     */
    public class Task11PascalsTriangle2
    {
        public static IList<int> Do(int rowIndex)
        {
            var result = new List<int>();
            
            result.Add(1);

            for (int j = 0; j < rowIndex; j++)
            {
                result.Add(1);

                int start = result.Count - 2;

                for (int i = start; i > 0 && j > 0; i--)
                {
                    result[i] = result[i] + result[i - 1];
                }
            }

            return result;
        }
    }
}
