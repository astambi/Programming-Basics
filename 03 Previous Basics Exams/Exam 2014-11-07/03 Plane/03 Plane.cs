using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Plane
{
    class Plane
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // odd
            int width = 3 * n;                      // height = 3*n - n/2;
            char backgroundSymbol = '.';
            char planeSymbol = '*';
            string outside = "";
            string inside = "";
            int outsideCount = 0;
            int insideCount = 0;

            // top		
            for (outsideCount = (width - 1) / 2; outsideCount > n - 2; outsideCount--)
            {
                outside = new string(backgroundSymbol, outsideCount);
                if (outsideCount == (width - 1) / 2)
                    Console.WriteLine("{0}{1}{0}", outside, planeSymbol);
                else
                {
                    insideCount = width - 2 - 2 * outsideCount;
                    inside = new string(backgroundSymbol, insideCount);
                    Console.WriteLine("{0}{1}{2}{1}{0}", outside, planeSymbol, inside);
                }
            }
            // curve
            for (outsideCount = n - 2; outsideCount >= 1; outsideCount -= 2)
            {
                outside = new string(backgroundSymbol, outsideCount);
                insideCount = width - 2 - 2 * outsideCount;
                inside = new string(backgroundSymbol, insideCount);
                Console.WriteLine("{0}{1}{2}{1}{0}", outside, planeSymbol, inside);
            }
            // wings
            string stem = planeSymbol + new string(backgroundSymbol, n) + planeSymbol;
            for (outsideCount = n - 2; outsideCount >= 1; outsideCount -= 2)
            {
                outside = new string(backgroundSymbol, outsideCount);
                if (outsideCount == n - 2)
                    Console.WriteLine("{0}{1}{2}{1}{0}", planeSymbol, outside, stem);
                else
                {
                    insideCount = n - 3 - outsideCount;
                    inside = inside = new string(backgroundSymbol, insideCount);
                    Console.WriteLine("{0}{1}{0}{2}{3}{2}{0}{1}{0}", planeSymbol, outside, inside, stem);
                }
            }
            // tail
            for (outsideCount = n - 1; outsideCount >= 0; outsideCount--)
            {
                outside = new string(backgroundSymbol, outsideCount);
                insideCount = width - 2 - 2 * outsideCount;
                if (outsideCount == 0) // last row
                    inside = new string(planeSymbol, insideCount);
                else
                    inside = new string(backgroundSymbol, insideCount);
                Console.WriteLine("{0}{1}{2}{1}{0}", outside, planeSymbol, inside);
            }
        }
    }
}
