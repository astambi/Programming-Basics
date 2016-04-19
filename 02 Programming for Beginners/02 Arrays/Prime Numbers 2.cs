using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    class Prime_Numbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 2; number <= n; number++)
            {
                if (IsPrime(number))
                    Console.WriteLine(number);
            }
        }

        static bool IsPrime(int number)
        {
            // much slower algorithm than Eratosthenes'
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
