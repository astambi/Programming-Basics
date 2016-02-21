using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sunlight
{
    class Sunlight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //n always odd
            int width = 3 * n;
            int middle = 3 * n / 2; 
            char sunlightSymbol = '*';
            char backgroundSymbol = '.';
            string outside = "";
            string inside = "";
            string sunlight = "";

            outside = new string(backgroundSymbol,(width - 1 ) / 2);
            // top row
            Console.WriteLine("{0}{1}{0}", outside, sunlightSymbol);
            // upper half 
            for (int i = 1; i < n; i++) // n - 1 length of vertical sunray
            {
                outside = new string(backgroundSymbol, i);
                inside = new string(backgroundSymbol, (width - 3 - 2 * i) / 2);
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", outside, sunlightSymbol, inside);
            }
            outside = new string(backgroundSymbol, n);
            inside = new string(sunlightSymbol, width - 2 * n);
            for (int i = n; i < middle; i++) // from n-1 till middle
                Console.WriteLine("{0}{1}{0}", outside, inside);
            // middle
            sunlight = new string(sunlightSymbol, width);
            Console.WriteLine(sunlight);
            // lower half 
            for (int i = n; i < middle; i++)
                Console.WriteLine("{0}{1}{0}", outside, inside);
            for (int i = n - 1; i > 0; i--)
            {
                outside = new string(backgroundSymbol, i);
                inside = new string(backgroundSymbol, (width - 3 - 2 * i) / 2);
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", outside, sunlightSymbol, inside);
            }
            // bottom row
            outside = new string(backgroundSymbol, (width - 1) / 2);
            Console.WriteLine("{0}{1}{0}", outside, sunlightSymbol);
        }
    }
}
