using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderByteChallenges
{
    /*
    First Reverse
    Have the function FirstReverse(str) take the str parameter being passed and return the string in reversed order. For example: if the input string is "Hello World and Coders" then your program should return the string sredoC dna dlroW olleH.

    Examples
    Input: "coderbyte"
    Output: etybredoc

    Input: "I Love Code"
    Output: edoC evoL I
   */
    public static class FirstReverse
    {
        public static string Reverse(string str)
        {
            string result = "";
            for (int i = 1; i <= str.Length; i++)
            {
                result += str[str.Length - i];
            }

            return result;
        }

        public static void Main()
        {

            Console.WriteLine(Reverse("coderbyte"));
            Console.Read();
        }
    }
}