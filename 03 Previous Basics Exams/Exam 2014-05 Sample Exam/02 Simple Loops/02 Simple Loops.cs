using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02_Simple_Loops
{
    class _02_Simple_Loops
    {
        static void Main(string[] args)
        {
            BigInteger prev3 = BigInteger.Parse(Console.ReadLine()); // num(k-3)
            BigInteger prev2 = BigInteger.Parse(Console.ReadLine()); // num(k-2)
            BigInteger prev1 = BigInteger.Parse(Console.ReadLine()); // num(k-1)
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            // NB bigInteger!!!!!

            BigInteger tribonacci = 0;
            if (n == 1)
                tribonacci = prev3;
            else if (n == 2)
                tribonacci = prev2;
            else if (n == 3)
                tribonacci = prev1;

            for (BigInteger k = 4; k <= n; k++)
            {
                tribonacci = prev1 + prev2 + prev3;
                prev3 = prev2;
                prev2 = prev1;
                prev1 = tribonacci;
            }
            Console.WriteLine(tribonacci);
        }
    }
}
