using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_The_Explorer
{
    class _03_The_Explorer
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // always odd
            int mid = (n + 1) / 2;
            char diamondSymbol = '*';
            char backgroundSymbol = '-';
            string outside = "";
            string inside = "";

            for (int i = 0; i < mid; i++)
            {
                outside = new string(backgroundSymbol, (n - 1) / 2 - i);
                if (i == 0)
                    Console.WriteLine("{0}{1}{0}", outside, diamondSymbol);
                else
                {
                    inside = new string(backgroundSymbol, 2 * i - 1);
                    Console.WriteLine("{0}{1}{2}{1}{0}", outside, diamondSymbol, inside);
                }
            }
            for (int i = 1; i < mid; i++)
            {
                outside = new string(backgroundSymbol, i);
                if (i == mid - 1)
                    Console.WriteLine("{0}{1}{0}", outside, diamondSymbol);
                else
                {
                    inside = new string(backgroundSymbol, n - 2 * i - 2);
                    Console.WriteLine("{0}{1}{2}{1}{0}", outside, diamondSymbol, inside);
                }
            }
        }
    }
}
