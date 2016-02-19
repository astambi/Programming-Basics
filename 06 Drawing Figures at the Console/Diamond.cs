using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char diamondSymbol = '*';
            char backgroundSymbol = '-';
            string outside = "";
            string inside = "";

            int firstDiamondCount = 1;
            if (n % 2 == 0)
                firstDiamondCount = 2;
            string firstDiamond = new string(diamondSymbol, firstDiamondCount);

            int outsideCount = (n - firstDiamondCount) / 2;
            int insideCount = 0;

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                outside = new string(backgroundSymbol, outsideCount);
                inside = new string(backgroundSymbol, insideCount);

                if (i == 0)
                    Console.WriteLine("{0}{1}{0}", outside, firstDiamond);
                else
                    Console.WriteLine("{0}{1}{2}{1}{0}", outside, diamondSymbol, inside);
                --outsideCount;
                insideCount = n - 2 - 2 * outsideCount;
            }
            for (int i = 1; i < n / 2; i++)
            {
                if (i == 1)
                    outsideCount = 1;
                else
                    ++outsideCount;
                insideCount = n - 2 - 2 * outsideCount;

                outside = new string(backgroundSymbol, outsideCount);
                inside = new string(backgroundSymbol, insideCount);
                Console.WriteLine("{0}{1}{2}{1}{0}", outside, diamondSymbol, inside);
            }
            if (n > 2 && n % 2 != 0)
            {
                outside = new string(backgroundSymbol, (n - firstDiamondCount) / 2);
                Console.WriteLine("{0}{1}{0}", outside, firstDiamond);
            }
        }
    }
}
