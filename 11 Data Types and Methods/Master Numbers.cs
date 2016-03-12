using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Numbers
{
    class Master_Numbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                bool masterNumber = IsPalindrome(i) && (SumOfDigits(i) % 7 == 0) && ContainsEvenDigit(i);
                if (masterNumber)
                    Console.WriteLine(i);
            }
        }

        static bool IsPalindrome(int number)
        {
            string digits = "" + number;
            for (int i = 0; i < digits.Length / 2; i++) // [0,len-1]
                if (digits[i] != digits[digits.Length - 1 - i])
                    return false;
            return true;
        }

        static int SumOfDigits(int number)
        {
            int sumDigits = 0;
            while (number > 0)
            {
                sumDigits += number % 10;
                number /= 10;
            }
            return sumDigits;
        }

        static bool ContainsEvenDigit(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                    return true;
                number /= 10;
            }
            return false;
        }
    }
}
