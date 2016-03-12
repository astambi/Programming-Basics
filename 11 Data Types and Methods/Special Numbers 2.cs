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
                bool specialDevisibleNumber = CheckIfSpecialNumber(sumDigits);
                Console.WriteLine("{0} -> {1}", i, specialDevisibleNumber);
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

        static bool CheckIfSpecialNumber(int number)
        {
            bool specialNumber = (number == 5) || (number == 7) || (number == 11);
            return specialNumber;
        }
    }
}
