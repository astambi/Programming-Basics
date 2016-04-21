using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger nFactoriel = 1;

            for (int i = 1; i <= n; i++)
                nFactoriel *= i;
            Console.WriteLine(nFactoriel);
        }
    }
}