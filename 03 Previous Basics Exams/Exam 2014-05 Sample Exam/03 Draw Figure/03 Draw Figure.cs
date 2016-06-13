using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Draw_Figure
{
    class _03_Draw_Figure
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mid = (n + 1) / 2;
            char insideSymbol = '*';
            char outsideSymbol = '.';
            string inside = "";
            string outside = "";

            for (int i = 0; i < mid; i++)
            {
                inside = new string(insideSymbol, n - 2 * i);
                outside = new string(outsideSymbol, i);
                Console.WriteLine("{0}{1}{0}", outside, inside);
            }
            for (int i = (n - 1) / 2 - 1; i >= 0; i--)
            {
                inside = new string(insideSymbol, n - 2 * i);
                outside = new string(outsideSymbol, i);
                Console.WriteLine("{0}{1}{0}", outside, inside);
            }
        }
    }
}
