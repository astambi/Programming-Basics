using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RockLq
{
    class RockLq
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // always odd
            int width = 3 * n;                      // height 2 * n
            char backgroundSymbol = '.';
            char outlineSymbol = '*';
            int outsideCount = n;
            int insideCount = n;
            string outside = "";
            string inside = "";

            // top	
            for (outsideCount = n; outsideCount > 0; outsideCount -= 2)
            {
                outside = new string(backgroundSymbol, outsideCount);
                insideCount = width - 2 - 2 * outsideCount;
                if (outsideCount == n)      // top row
                    inside = new string(outlineSymbol, insideCount);
                else
                    inside = new string(backgroundSymbol, insideCount);
                Console.WriteLine("{0}{1}{2}{1}{0}", outside, outlineSymbol, inside);
            }
            // mushroom
            inside = outlineSymbol + new string(backgroundSymbol, n) + outlineSymbol;
            for (outsideCount = n - 2; outsideCount >= 1; outsideCount -= 2)
            {
                outside = new string(backgroundSymbol, outsideCount);
                if (outsideCount == n - 2)  // shoulders
                    Console.WriteLine("{0}{1}{2}{1}{0}", outlineSymbol, outside, inside);
                else
                {
                    insideCount = n - 3 - outsideCount;
                    string inside2 = new string(backgroundSymbol, insideCount);
                    Console.WriteLine("{0}{1}{0}{3}{2}{3}{0}{1}{0}", outlineSymbol, outside, inside, inside2);
                }
            }
            // stem
            for (outsideCount = n - 1; outsideCount >= 0; outsideCount--)
            {
                outside = new string(backgroundSymbol, outsideCount);
                if (outsideCount != 0)
                    inside = new string(backgroundSymbol, width - 2 - 2 * outsideCount);
                else                        //bottom row
                    inside = new string(outlineSymbol, width - 2 - 2 * outsideCount);
                Console.WriteLine("{0}{1}{2}{1}{0}", outside, outlineSymbol, inside);
            }
        }
    }
}
