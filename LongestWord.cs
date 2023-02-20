using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CoderByteChallenges
{
    /*
    Longest Word
    Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the string. If there are two or more words that are the same length, return the first word from the string with that length. Ignore punctuation and assume sen will not be empty. Words may also contain numbers, for example "Hello world123 567"

    Examples
    Input: "fun&!! time"
    Output: time

    Input: "I love dogs"
    Output: love
    */
    public static class LongestWord
    {
        public static string Longest(string sen)
        {
            var arr = sen.Split(' ','#','$','%','^','!','½','&','{',']','[','}','^','=','?','*','-','+','/','(',')','|','_','£');
            int longest = 0, index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > longest)
                {
                    longest = arr[i].Length;
                    index = i;
                }
            }

            return arr[index];
        }

        public static void Main()
        {
            // keep this function call here
            Console.WriteLine(Longest("I love dogs"));
            Console.Read();
        }
    }
}