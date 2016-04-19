using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Special_Numbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sumDigits = 0;
                while (number > 0)
                {
                    sumDigits += number % 10;
                    number /= 10;
                }
                bool isSpecialNumber = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
            }
        }
    }
}
