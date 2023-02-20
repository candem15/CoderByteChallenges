using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderByteChallenges
{
    /*
    Min Window Substring
    Have the function MinWindowSubstring(strArr) take the array of strings stored in strArr, which will contain only two strings, the first parameter being the string N and the second parameter being a string K of some characters, and your goal is to determine the smallest substring of N that contains all the characters in K. For example: if strArr is ["aaabaaddae", "aed"] then the smallest substring of N that contains the characters a, e, and d is "dae" located at the end of the string. So for this example your program should return the string dae.

    Another example: if strArr is ["aabdccdbcacd", "aad"] then the smallest substring of N that contains all of the characters in K is "aabd" which is located at the beginning of the string. Both parameters will be strings ranging in length from 1 to 50 characters and all of K's characters will exist somewhere in the string N. Both strings will only contains lowercase alphabetic characters.

    Examples
    Input: new string[] {"ahffaksfajeeubsne", "jefaa"}
    Output: aksfaje

    Input: new string[] {"aaffhkksemckelloe", "fhea"}
    Output: affhkkse
    */
    public class MinWindowSubstring
    {
        public static string MinWindow(string[] strArr)
        {
            var subToContain = strArr[1].ToCharArray();
            var subToCheck = strArr[0];

            int startIndex = 0, endIndex = subToCheck.Length - 1;

            for (int i = 0; i < subToCheck.Length; i++)
            {
                if (subToContain.All(x => subToCheck.Substring(i).Contains(x)))
                {
                    startIndex = i;
                }
                else
                {
                    for (int j = endIndex; j > startIndex; j--)
                    {
                        if (subToContain.All(x => subToCheck.Substring(startIndex, j - startIndex).Contains(x)))
                        {
                            endIndex = j;
                        }
                        else
                            break;
                    }
                }
            }
            return subToCheck.Substring(startIndex, endIndex - startIndex);
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(MinWindow(new string[] { "ahffaksfajeeubsne", "jefaa"}));
        }
    }
}