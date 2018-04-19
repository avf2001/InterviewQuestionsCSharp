using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StringQuestions
{
    /*
     * Write a method to replace all spaces in a string with '%20'. You may assume that the string
     * has sufficient space at the end to hold the additional characters, and that you are given the "true"
     * length of the string. (Note: If implementing in Java, please use a character array so that you can
     * perform this operation in place.)
     * 
     * EXAMPLE
     * Input: "Mr John Smith ", 13
     * Output: "Mr%20John%20Smith"
     * 
     * Cracking the Coding Interview, p. 90, 1.3
     */
    public class Task03URLify
    {
        public static string Do(string input)
        {
            var builder = new StringBuilder();
            
            using (var reader = new StringReader(input))
            {
                while (reader.Peek() != -1)
                {
                    char c = (char)reader.Peek();
                    if (char.IsWhiteSpace(c))
                    {
                        while (char.IsWhiteSpace(c))
                        {
                            reader.Read();
                            c = (char)reader.Peek();
                        }
                        builder.Append("%20");
                    }
                    else builder.Append((char)reader.Read());
                }
            }           

            return builder.ToString();
        }
    }
}
