using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_3_Numbers_2
{
    class Sum_3_Numbers_2
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double halfSum = (a + b + c) / 2.00;

            if (halfSum == c)
                Console.WriteLine("{0} + {1} = {2}", Math.Min(a, b), Math.Max(a, b), c);
            else if (halfSum == a)
                Console.WriteLine("{0} + {1} = {2}", Math.Min(b, c), Math.Max(b, c), a);
            else if (halfSum == b)
                Console.WriteLine("{0} + {1} = {2}", Math.Min(a, c), Math.Max(a, c), b);
            else
                Console.WriteLine("No");
        }
    }
}
