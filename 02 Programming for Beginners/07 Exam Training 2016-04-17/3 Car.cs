using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Car
{
    class Car
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // even
            int width = 3 * n;
            int roofHeight = n / 2;
            int wheelsHeight = n / 2 - 1;

            char backgroundSymbol = '.';
            char carSymbol = '*';
            string inside = "";
            string outside = "";

            // roof
            for (int i = 0; i < n/2; i++)
            {
                if (i == 0)
                    inside = new string(carSymbol, width - 2 - 2 * (n - i));
                else
                    inside = new string(backgroundSymbol, width - 2 - 2 * (n - i));
                outside = new string(backgroundSymbol, n - i);
                Console.WriteLine("{0}*{1}*{0}", outside, inside);
            }
            // body
            for (int i = 0; i < n/2; i++)
            {
                if (i == 0)
                {
                    outside = new string(carSymbol, n / 2);
                    inside = new string(backgroundSymbol, 2 * n - 2);
                    Console.WriteLine("*{0}{1}{0}*", outside, inside);
                }
                else if(i == n/2 - 1)
                {
                    inside = new string(carSymbol, width);
                    Console.WriteLine("{0}", inside);
                }
                else
                {
                    inside = new string(backgroundSymbol, width - 2);
                    Console.WriteLine("*{0}*", inside);
                }
            }
            // wheels
            for (int i = 0; i < n/2 - 1; i++)
            {
                outside = new string(backgroundSymbol, n / 2);
                inside = new string(backgroundSymbol, n / 2 - 1);
                if (i == n/2 - 2)
                {
                    string wheel = new string(carSymbol, n / 2 - 1);
                    Console.WriteLine("{0}*{2}*{1}{1}*{2}*{0}", outside, inside, wheel);
                }
                else
                    Console.WriteLine("{0}*{1}*{1}{1}*{1}*{0}", outside, inside);
            }
        }
    }
}