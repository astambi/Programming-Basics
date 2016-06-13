using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nested_Loops
{
    class Nested_Loops
    {
        static void Main(string[] args)
        {
            int secretNumber = int.Parse(Console.ReadLine());
            int countBulls = int.Parse(Console.ReadLine());
            int countCows = int.Parse(Console.ReadLine());
            List<int> guessNumbers = new List<int>();

            // try guess numbers
            for (int guessNumber = 1111; guessNumber <= 9999; guessNumber++)
            {
                bool isValidFormat = ContrainsValidDigits(guessNumber);
                if (isValidFormat)
                {
                    int[] currentCounts = CountBullsCows(secretNumber, guessNumber);
                    bool hasCorrectCounts = currentCounts[0] == countBulls &&
                                            currentCounts[1] == countCows;
                    if (hasCorrectCounts)
                        guessNumbers.Add(guessNumber);
                }                
            }
            // print result
            if (guessNumbers.Count > 0)
                Console.WriteLine(string.Join(" ", guessNumbers));
            else
                Console.WriteLine("No");
        }

        static bool ContrainsValidDigits(int number)
        {
            bool containsValidDigits = !number.ToString().Contains("0");
            return containsValidDigits;
        }

        static int[] CountBullsCows(int number1, int number2)
        {
            int[] counts = new int[2]; // bulls, cows
            // list of digits from number1
            List<int> digitsNum1 = new List<int>();
            while (number1 > 0)
            {
                digitsNum1.Add(number1 % 10);
                number1 /= 10;
            }
            //digitsNum1.Reverse();

            // list of digits from number2
            List<int> digitsNum2 = new List<int>();
            while (number2 > 0)
            {
                digitsNum2.Add(number2 % 10);
                number2 /= 10;
            }
            //digitsNum2.Reverse();

            // count bulls (matching digits at the same indices in numbers)
            for (int i = 0; i < digitsNum1.Count; i++)
            {
                if (digitsNum1[i] == digitsNum2[i])
                {
                    counts[0]++;
                    digitsNum1.RemoveAt(i);
                    digitsNum2.RemoveAt(i);
                    i--;
                }
            }
            // count cows (matching digits at different indices in numbers)
            for (int i = 0; i < digitsNum1.Count; i++)
            {
                int currentDigit = digitsNum1[i];
                if (digitsNum2.Contains(currentDigit))
                {
                    counts[1]++;
                    digitsNum1.RemoveAt(i);
                    digitsNum2.Remove(currentDigit);
                    i--;
                }
            }
            return counts;
        }
    }
}
