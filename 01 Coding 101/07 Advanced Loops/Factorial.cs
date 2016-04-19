using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nfactorial = 1;

            for (int i = 1; i <= n; i++)
                nfactorial *= i;
            Console.WriteLine(nfactorial);
        }
    }
}
