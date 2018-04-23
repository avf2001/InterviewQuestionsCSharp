using System;
using System.Collections.Generic;
using System.Text;

namespace StringQuestions
{
    /*
     * Implement a method to perform basic string compression using the counts 
     * of repeated characters. For example, the string aabcccccaaa would become a2blc5a3. If the 
     * "compressed" string would not become smaller than the original string, your method should return
     * the original string. You can assume the string has only uppercase and lowercase letters (a - z).
     * 
     * Cracking the Coding Interview, p. 91, 1.6
     */
    public class Task06StringCompression
    {
        public static string Do(string str)
        {
            var retString = string.Empty;
            var prevChar = string.Empty;
            var counter = 1;

            for (var i = 0; i < str.Length; i++)
            {
                var curChar = str[i].ToString();

                if (curChar != prevChar)
                {
                    if (!string.IsNullOrEmpty(prevChar))
                    {
                        retString += prevChar + counter.ToString();
                        prevChar = curChar;
                        counter = 1;
                    }
                }
                else
                {                    
                    counter++;
                }

                prevChar = curChar;
            }

            retString += prevChar + counter;

            return retString;
        }
    }
}
