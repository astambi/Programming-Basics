using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
            double count4 = 0;
            double count5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= 800)
                    ++count5;
                else if (number >= 600)
                    ++count4;
                else if (number >= 400)
                    ++count3;
                else if (number >= 200)
                    ++count2;
                else
                    ++count1;
            }
            Console.WriteLine("{0:0.00}%", 100 * count1 / n);
            Console.WriteLine("{0:0.00}%", 100 * count2 / n);
            Console.WriteLine("{0:0.00}%", 100 * count3 / n);
            Console.WriteLine("{0:0.00}%", 100 * count4 / n);
            Console.WriteLine("{0:0.00}%", 100 * count5 / n);
        }
    }
}
