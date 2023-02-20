using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoderByteChallenges
{
    /*
    First Factorial
    Have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it. For example: if num = 4, then your program should return (4 * 3 * 2 * 1) = 24. For the test cases, the range will be between 1 and 18 and the input will always be an integer.

    Examples
    Input: 4
    Output: 24

    Input: 8
    Output: 40320
    */
    public static class FirstFactorial
    {
        public static int Factorial(int num)
        {
            if (num <= 0)
                return 1;
            else
                return num * Factorial(num - 1);

        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(Factorial(8));
            Console.Read();
        }
    }
}