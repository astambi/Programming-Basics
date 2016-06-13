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
            int n = int.Parse(Console.ReadLine());                  //n always odd
            int width = 3 * n;
            int middle = 3 * n / 2; 
            char sunlightSymbol = '*';
            char backgroundSymbol = '.';
            string outside = "";
            string inside = "";
            string sunlight = "";

            // top row
            outside = new string(backgroundSymbol,(width - 1 ) / 2);
            Console.WriteLine("{0}{1}{0}", outside, sunlightSymbol);
            // upper sunrays
            for (int i = 1; i < n; i++)                             // [1, n - 1] length of sunray
            {
                outside = new string(backgroundSymbol, i);
                inside = new string(backgroundSymbol, (width - 3 - 2 * i) / 2);
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", outside, sunlightSymbol, inside);
            }
            // below upper sunray & above mid
            outside = new string(backgroundSymbol, n);
            inside = new string(sunlightSymbol, width - 2 * n);
            for (int i = n; i < middle; i++)                        // (n - 1, middle)
                Console.WriteLine("{0}{1}{0}", outside, inside);
            // middle
            sunlight = new string(sunlightSymbol, width);
            Console.WriteLine(sunlight);
            // below mid & above lower sunrays 
            for (int i = n; i < middle; i++)                        // (n - 1, middle)
                Console.WriteLine("{0}{1}{0}", outside, inside);
            // lower sunrays                                        // [1, n - 1] length of sunray
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
