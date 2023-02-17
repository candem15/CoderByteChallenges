using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CoderByteChallenges
{
    /*
    Codeland Username Validation
    Have the function CodelandUsernameValidation(str) take the str parameter being passed and determine if the string is a valid username according to the following rules:

    1. The username is between 4 and 25 characters.
    2. It must start with a letter.
    3. It can only contain letters, numbers, and the underscore character.
    4. It cannot end with an underscore character.

    If the username is valid then your program should return the string true, otherwise return the string false.

    Examples
    Input: "aa_"
    Output: false

    Input: "u__hello_world123"
    Output: true
    */
    public static class CoderlandUsernameValidation
    {
        public static string UsernameValidation(string str)
        {
            var acceptables = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_";
            var firstIndexTest = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (str.Length < 4 || str.Length > 25 || !firstIndexTest.Contains(str[0]))
                return "false";
            if (str[str.Length - 1] == '_')
                return "false";
            foreach (var item in str)
            {
                if (!acceptables.Contains(item))
                    return "false";
            }
            return "true";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(UsernameValidation("u__hello_world123"));
            Console.Read();
        }
    }
}