﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Numbers_2
{
    class Master_Numbers_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // is palindrome
            // sum digits % 7 == 0
            // contains min 1 even digit

            for (int i = 0; i < n; i++)
            {
                bool masterNumber = IsPalidrome(i) && (SumOfDigits(i) % 7 == 0) && ContainsEvenDigit(i);
                if (masterNumber)
                    Console.WriteLine(i);
            }
        }

        static bool IsPalidrome(int number)
        {
            string numberStr = number.ToString();
            int len = numberStr.Length;
            for (int i = 0; i < len / 2; i++)   // [0, len-1] = > [0] vs [len-1] <=> [i] vs [len-1 -i]
            {
                if (numberStr[i] != numberStr[len-1 - i])
                    return false;
            }
            return true;
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static bool ContainsEvenDigit(int number)
        {
            while(number > 0)
            {
                int digit = number % 10;
                bool even = digit % 2 == 0; 
                if (even)
                    return true;
                number /= 10;
            }
            return false;
        }
    }
}
