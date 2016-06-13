using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Wine_Glass
{
    class _03_Wine_Glass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // height, width, always even
            int stemHeight = n / 2 - 1;
            char wineSymbol = '*';
            char stemSymbol = '|';
            char backgroundSymbol = '.';
            char bottomSymbol = '-';
            string background = "";
            string wine = "";

            for (int i = 0; i < n / 2; i++)
            {
                wine = new string(wineSymbol, n - 2 - 2 * i);
                background = new string(backgroundSymbol, i);
                Console.WriteLine("{0}\\{1}/{0}", background, wine);
            }
            string stem = new string(stemSymbol, 2);
            if (n >= 12) stemHeight--;
            for (int i = 0; i < stemHeight; i++)
                Console.WriteLine("{0}{1}{0}", background, stem);
            string bottom = new string(bottomSymbol, n);
            for (int i = 0; i < n / 2 - stemHeight; i++)
                Console.WriteLine("{0}", bottom);
        }
    }
}
