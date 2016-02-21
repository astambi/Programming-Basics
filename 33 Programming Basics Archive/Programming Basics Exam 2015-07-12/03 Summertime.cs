using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Summertime
{
    class Summertime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int widthTop = n + 1;
            int widthBottom = 2 * n;
            int curveCount = (widthBottom - widthTop) / 2;
            char bottleSymbol = '*';
            char fullBottleSymbol = '@';
            char emptyBottleSymbol = '.';
            char backgroundSymbol = ' ';

            // bottle top
            string backgroundTop = new string(backgroundSymbol, (widthBottom - widthTop) / 2);
            string bottleTop = new string(bottleSymbol, widthTop);
            Console.WriteLine("{0}{1}", backgroundTop, bottleTop);            
            // bottle neck
            string bottleneckTop = new string(backgroundSymbol, widthTop - 2);
            for (int i = 0; i < n - curveCount; i++)
                Console.WriteLine("{0}{1}{2}{1}", backgroundTop, bottleSymbol, bottleneckTop);
            // bottle curve
            for (int i = 1; i < curveCount; i++)
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
