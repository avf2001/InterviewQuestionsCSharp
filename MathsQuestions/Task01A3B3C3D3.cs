using System;
using System.Collections.Generic;
using System.Linq;

namespace MathsQuestions
{
    /*
     * Print all positive integer solutions to the equation a3 + b3 = c3 + d3 where a, b, c and d are integers between 1 and 1000.
     */
    public class Task01A3B3C3D3
    {
        public static IList<Tuple<int, int, int, int>> Do(int n)
        {
            /*
            Dictionary<int, List<Tuple<int, int>>> solutions = new Dictionary<int, List<Tuple<int, int>>>();

            for (int a = 1; a <= n; ++a)
                for (int b = a; b <= n; ++b)
                {
                    int sum = a * a * a + b * b * b;

                    List<Tuple<int, int>> list = null;
                    if (!solutions.TryGetValue(sum, out list))
                    {
                        list = new List<Tuple<int, int>>();
                        solutions.Add(sum, list);
                    }
                    list.Add(new Tuple<int, int>(a, b));
                }            

            return solutions;
            */
                        
            var dict = new List<Tuple<int, int, int, int>>();
            var temp = new Dictionary<int, Tuple<int, int, int, int>>();

            for (var a = 1; a <= n; a++)
            {
                for (var b = a; b <= n; b++)
                {
                    var result = a * a * a + b * b * b;

                    temp.Add(result, new Tuple<int, int, int, int>(a, b, 0, 0));
                }
            }

            for (var c = 1; c <= n; c++)
            {
                for (var d = c; d <= n; d++)
                {
                    var result = c * c * c + d * d * d;

                    if (temp.ContainsKey(result))
                    {
                        dict.Add(new Tuple<int, int, int, int>(temp[result].Item1, temp[result].Item2, c, d ));
                    }                    
                }
            }

            return dict;            
        }
    }
}
