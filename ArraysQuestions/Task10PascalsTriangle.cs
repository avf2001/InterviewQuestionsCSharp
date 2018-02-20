using System.Collections.Generic;

namespace ArraysQuestions
{
    public class Task10PascalsTriangle
    {
        public static IList<IList<int>> Do(int numRows)
        {
            var result = new List<IList<int>>();

            if (numRows == 0) return result;

            result.Add(new List<int>() { 1 });

            if (numRows > 1)
            {
                for (var i = 1; i < numRows; i++)
                {
                    var list = new List<int>();                    

                    for (var j = 0; j <= i; j++)
                    {
                        var leftValue = j == 0 ? 0 : result[i-1][j-1];
                        var rightValue = j == i ? 0 : result[i-1][j];

                        list.Add(leftValue + rightValue);
                    }

                    result.Add(list);
                }
            }

            return result;
        }
    }
}
