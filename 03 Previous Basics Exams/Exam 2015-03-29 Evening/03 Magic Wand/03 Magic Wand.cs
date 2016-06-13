using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Magic_Wand
{
    class _03_Magic_Wand
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //n always odd
            int width = 3 * n + 2;
            int stemWidth = width - 2 * n;
            int shoulderHeight = (n + 1) / 2;
            char backgroundSymbol = '.';
            char wandSymbol = '*';
            string background = "";
            string inside = "";

            //wand top
            int outsideWidth = (width - 1)/2;
            int insideWidth = 0;
            while (outsideWidth >= n) 
            {
                background = new string(backgroundSymbol, outsideWidth);
                inside = new string(backgroundSymbol, insideWidth);
                if (insideWidth == 0)
                    Console.WriteLine("{0}{1}{0}",background,wandSymbol);
                else
                    Console.WriteLine("{0}{1}{2}{1}{0}", background, wandSymbol, inside);
                --outsideWidth;
                insideWidth = width - 2 * outsideWidth - 2;
            }
            //wand shoulders horizontal
            string wandShouldersEdge = new string(wandSymbol, n);
            string wandShouldersInside = new string(backgroundSymbol, stemWidth);
            Console.WriteLine("{0}{1}{0}", wandShouldersEdge, wandShouldersInside);
            //wand shoulders 
            for (int i = 1; i < shoulderHeight; i++)
            {
                insideWidth = width - 2 * i - 2;
                background = new string(backgroundSymbol, i);
                inside = new string(backgroundSymbol, insideWidth);
                Console.WriteLine("{0}{1}{2}{1}{0}", background, wandSymbol, inside);
            }
            string wandStem = wandSymbol + new string(backgroundSymbol, stemWidth - 2) + wandSymbol;
            string wandWing = wandSymbol + new string(backgroundSymbol, shoulderHeight - 1) + wandSymbol;
            //wand wings
            for (int i = shoulderHeight - 2; i >= 0; i--)
            {
                insideWidth = n - i - 2 - shoulderHeight + 1;
                background = new string(backgroundSymbol, i);
                inside = new string(backgroundSymbol, insideWidth);
                Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", background, wandWing, inside, wandStem);
            }
            //wand wings horizontal 
            wandShouldersEdge = new string(wandSymbol, shoulderHeight);
            wandShouldersInside = new string(backgroundSymbol, n - shoulderHeight);
            Console.WriteLine("{0}{1}{2}{1}{0}", wandShouldersEdge, wandShouldersInside, wandStem);
            //wand stem
            string backgroundBottom = new string(backgroundSymbol, n);
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0}{1}{0}", backgroundBottom, wandStem);
            //wand base
            string wandBottom = new string(wandSymbol, stemWidth);
            Console.WriteLine("{0}{1}{0}", backgroundBottom, wandBottom);
        }
    }
}
