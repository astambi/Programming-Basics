using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_House
{
    class _03_House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // odd number >= 5	
            int mid = (1 + n) / 2;
            int widthUnderRoof = n / 4;
            // height, width = n
            // height roof = (1+n)/2
            // width under roof = n/4 rounded down
            char houseSymbol = '*';
            char backgroundSymbol = '.';
            string outside = "";
            string inside = "";

            // roof
            for (int i = 0; i < mid; i++)
            {
                outside = new string(backgroundSymbol, (n - 1) / 2 - i);
                if (i == 0) // roof top
                    Console.WriteLine("{0}{1}{0}", outside, houseSymbol);
                else if (i == mid - 1) // roof bottom
                    Console.WriteLine(new string(houseSymbol, n));
                else
                {
                    inside = new string(backgroundSymbol, 2 * i - 1);
                    Console.WriteLine("{0}{1}{2}{1}{0}", outside, houseSymbol, inside);
                }
            }
            // house
            outside = new string(backgroundSymbol, widthUnderRoof);
            inside = new string(backgroundSymbol, n - 2 - 2 * widthUnderRoof);
            for (int i = 1; i < mid; i++)
            {
                if (i == mid - 1) // ground
                    inside = new string(houseSymbol, n - 2 - 2 * widthUnderRoof);
                Console.WriteLine("{0}{1}{2}{1}{0}", outside, houseSymbol, inside);
            }
        }
    }
}
