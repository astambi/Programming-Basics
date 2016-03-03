using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums_Step_3
{
    class ProgSums_Step_3ram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int remainder = i % 3;

                if (remainder == 1)
                    sum1 += number;
                else if (remainder == 2)
                    sum2 += number; 
                else if (remainder == 0)
                    sum3 += number;
            }
            Console.WriteLine("sum1 = {0}\nsum2 = {1}\nsum3 = {2}", sum1, sum2, sum3);
        }
    }
}
