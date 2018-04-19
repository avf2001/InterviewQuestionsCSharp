using System;
using System.Collections.Generic;
using System.Text;

namespace StringQuestions
{
    /*
     * Given two strings, write a method to decide if one is a permutation of the other.
     * 
     * Cracking the Coding Interview, p. 90, 1.2
     */
    public class Task02CheckPermutation
    {
        public static bool Do1(string str1, string str2)
        {
            var arrStr1 = str1.ToCharArray();
            Array.Sort(arrStr1);

            var arrStr2 = str2.ToCharArray();
            Array.Sort(arrStr2);

            return new string(arrStr1).Equals(new string(arrStr2));
        }

        public static bool Do2(string str1, string str2)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (var i = 0; i < str1.Length; i++)
            {
                if (dict.ContainsKey(str1[i]))
                {
                    dict[str1[i]]++;
                }
                else
                {
                    dict[str1[i]] = 1;
                }
            }

            for (var i = 0; i < str2.Length; i++)
            {
                if (dict.ContainsKey(str2[i]))
                {
                    dict[str2[i]]--;

                    if (dict[str2[i]] == 0) dict.Remove(str2[i]);
                }               
            }

            return dict.Count == 0;
        }
    }
}
