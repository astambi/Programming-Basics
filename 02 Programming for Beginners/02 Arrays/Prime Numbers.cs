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

            bool[] primes = new bool[n + 1];    // [0,n]
            for (int i = 0; i <= n; i++)
                primes[i] = true;               // define all numbers as primes
            primes[0] = primes[1] = false;      // 0, 1 non-primes

            // Sieve of Eratosthenes
            for (int number = 2; number <= n; number++)
            {
                if (primes[number])
                    MarkNonPrimes(primes, number);
            }

            for (int i = 0; i <= n; i++)
            {
                if (primes[i])
                    Console.WriteLine(i);
            }
        }

        static void MarkNonPrimes(bool[] primes, int step)
        {
            for (int i = 2 * step; i < primes.Length; i += step)
                primes[i] = false;
        }
    }
}
