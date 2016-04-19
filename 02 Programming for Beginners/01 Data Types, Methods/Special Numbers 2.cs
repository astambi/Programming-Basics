using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers_2
{
    class Special_Numbers_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumDigits = SumOfDigits(i);
                bool isSpecialNumber = IsSpecialNumber(sumDigits);
                Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
            }
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

        static bool IsSpecialNumber(int number)
        {
            bool isSpecialNumber = (number == 5) || (number == 7) || (number == 11);
            return isSpecialNumber;
        }
    }
}