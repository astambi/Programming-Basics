using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Summertime_2
{
    class Summertime_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // always odd
            int bottleHeight = 3 * n + 1;
            int widthTop = n + 1;
            int widthBottom = 2 * n;
            char bottleSymbol = '*';
            char fullBottleSymbol = '@';
            char emptyBottleSymbol = '.';
            char backgroundSymbol = ' ';

            // bottle top
            string backgroundTop = new string(backgroundSymbol, (widthBottom - widthTop) / 2);
            string bottleTop = new string(bottleSymbol, widthTop);
            Console.WriteLine("{0}{1}", backgroundTop, bottleTop);
            // height bottle neck + bottle curve = n - 1 (e.g. bottleHeight - 2 - 2 * n)
            // bottle neck
            string bottleneckTop = new string(backgroundSymbol, widthTop - 2);
            for (int i = 0; i < (n + 1) / 2; i++)           // (n + 1) / 2
                Console.WriteLine("{0}{1}{2}{1}", backgroundTop, bottleSymbol, bottleneckTop);
            // bottle curve
            for (int i = 1; i < (n - 1) / 2; i++)           // (n - 1) / 2 - 1
            {
                widthTop += 2;
                int widthCurve = (widthBottom - widthTop) / 2;
                string backgroundCurving = new string(backgroundSymbol, widthCurve);
                string bottleCurving = new string(backgroundSymbol, widthBottom - 2 - 2 * widthCurve);
                Console.WriteLine("{0}{1}{2}{1}", backgroundCurving, bottleSymbol, bottleCurving);
            }
            // bottle empty
            string bottleEmpty = new string(emptyBottleSymbol, widthBottom - 2);
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0}{1}{0}", bottleSymbol, bottleEmpty);
            // bottle full
            string bottleFull = new string(fullBottleSymbol, widthBottom - 2);
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0}{1}{0}", bottleSymbol, bottleFull);
            // bottle bottom
            string bottleBottom = new string(bottleSymbol, widthBottom);
            Console.WriteLine(bottleBottom);
        }
    }
}
