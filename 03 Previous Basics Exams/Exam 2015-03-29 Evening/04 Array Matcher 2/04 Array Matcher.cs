using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Array_Matcher_2
{
    class _04_Array_Matcher_2
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            char[] left =   input[0].ToCharArray();
            char[] right =  input[1].ToCharArray();
            string command = input[2];
            string result = "";

            if (command == "join")                  result = GetCommonChars(left, right);
            else if (command == "left exclude")     result = GetNotExcludedChars(right, left);
            else if (command == "right exclude")    result = GetNotExcludedChars(left, right);
            Console.WriteLine(result);
        }
        static string GetCommonChars(char[] arrayLeft, char[] arrayRight)
        {
            string result = "";
            Array.Sort(arrayLeft);
            foreach (char leftChar in arrayLeft)
                if (arrayRight.Contains(leftChar)) result += leftChar;
            return result;
        }
        static string GetNotExcludedChars(char[] arraySource, char[] arrayToExclude)
        {
            string result = "";
            Array.Sort(arraySource);
            foreach (char charInSource in arraySource)
                if (!arrayToExclude.Contains(charInSource)) result += charInSource;
            return result;
        }
    }
}