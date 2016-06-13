using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Array_Matcher
{
    class _04_Array_Matcher
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            char[] left = input[0].ToCharArray();
            char[] right = input[1].ToCharArray();
            string command = input[2];
            string result = "";

            if (command == "join")                  result = GetCommonChars(left, right);
            else if (command == "left exclude")     result = GetNotExcludedChars(right, left);
            else if (command == "right exclude")    result = GetNotExcludedChars(left, right);
            Console.WriteLine(result);
        }
        static string GetCommonChars(char[] left, char[] right)
        {
            string result = "";
            Array.Sort(left);
            foreach (char leftChar in left)
                foreach (char rightChar in right)
                    if (leftChar == rightChar)  result += leftChar;
            return result;
        }
        static string GetNotExcludedChars(char[] arraySource, char[] arrayToExclude)
        {
            string result = "";
            Array.Sort(arraySource);
            foreach (char charSource in arraySource)
            {
                bool commonChar = false;
                foreach (char charToExclude in arrayToExclude)
                    if (charSource == charToExclude)
                    {
                        commonChar = true; break;
                    }
                if (!commonChar) result += charSource;
            }
            return result;
        }
    }
}