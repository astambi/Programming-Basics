using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fibonacci0 = 0;
            int fibonacci1 = 1;
            Console.WriteLine("{0}\n{1}", fibonacci0, fibonacci1);

            for (int i = 1; i <= n; i++)
            {
                int fibonacciCurrent = fibonacci0 + fibonacci1;
                Console.WriteLine("{0}", fibonacciCurrent);

                fibonacci0 = fibonacci1;
                fibonacci1 = fibonacciCurrent;
            }
        }
    }
}
