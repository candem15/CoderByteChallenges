namespace CoderByteChallenges
{
    /*
    Find Intersection
    Have the function FindIntersection(strArr) read the array of strings stored in strArr which will contain 2 elements: the first element will represent a list of comma-separated numbers sorted in ascending order, the second element will represent a second list of comma-separated numbers (also sorted). Your goal is to return a comma-separated string containing the numbers that occur in elements of strArr in sorted order. If there is no intersection, return the string false.

    Examples
    Input: new string[] {"1, 3, 4, 7, 13", "1, 2, 4, 13, 15"}
    Output: 1,4,13

    Input: new string[] {"1, 3, 9, 10, 17, 18", "1, 4, 9, 10"}
    Output: 1,9,10
    */
    public static class FindIntersection
    {
        public static string FindIntersct(string[] strArr)
        {
            string result = "";

            string[] splittedArr = strArr[0].Replace(" ", string.Empty).Split(',');
            string[] splittedArr2 = strArr[1].Replace(" ", string.Empty).Split(',');

            foreach (string item in splittedArr)
            {
                if (splittedArr2.Contains(item))
                    result += item + ",";
            }

            if (result.Length == 0)
                return "false";

            result = result.Substring(0, result.Length - 1);

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindIntersct(new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" }));
            Console.Read();
        }
    }
}