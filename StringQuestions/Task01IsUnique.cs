using System;

namespace StringQuestions
{
    /*
     * Implement an algorithm to determine if a string has all unique characters.
     * What if you cannot use additional data structures?
     * 
     * Cracking the Coding Interview, p. 90, 1.1
     */
    public class Task01IsUnique
    {
        public static bool Do1(string str)
        {
            if (str.Length > 128) return false;
            
            bool[] char_set = new bool[128];

            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];

                if (char_set[val])
                {   //Already found this char in string
                    return false;
                }

                char_set[val] = true;
            }

            return true;
        }
    }
}
