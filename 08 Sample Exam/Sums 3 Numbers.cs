using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums_3_Numbers
{
    class Sums_3_Numbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double halfSum = (a + b + c) / 2.00;

            if (a + b == halfSum)
                Console.WriteLine("{0} + {1} = {2}", Math.Min(a, b), Math.Max(a, b), c);
            else if (b + c == halfSum)
                Console.WriteLine("{0} + {1} = {2}", Math.Min(b, c), Math.Max(b, c), a);
            else if (a + c == halfSum)
                Console.WriteLine("{0} + {1} = {2}", Math.Min(a, c), Math.Max(a, c), b);
            else
                Console.WriteLine("No");
        }
    }
}
