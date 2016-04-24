using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strawberry
{
    class Strawberry
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // odd
            int width = 2 * n + 3;
            
            char strawberrySymbol = '.';
            char backgroundSymbol = '-';
            string inside = "";
            string outside = "";

            for (int i = 0; i < n - 2; i+=2)
            {
                inside = new string(backgroundSymbol, n-i);
                outside = new string(backgroundSymbol, i);
                Console.WriteLine("{1}\\{0}|{0}/{1}", inside, outside);
            }
            for (int i = n; i >= 0; i-=2)
            {
                inside = new string(strawberrySymbol, width - 2 - 2 * i);
                outside = new string(backgroundSymbol, i);
                Console.WriteLine("{0}#{1}#{0}", outside, inside);
            }
            for (int i = 0; i <= n; i++)
            {
                inside = new string(strawberrySymbol, width - 2 - 2 * i);
                outside = new string(backgroundSymbol, i);
                Console.WriteLine("{0}#{1}#{0}", outside, inside);
            }
        }
    }
}
