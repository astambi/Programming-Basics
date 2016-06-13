using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sunglasses
{
    class _03_Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // always odd
            int width = 5 * n;
            char lensesSymbol = '/';
            char frameSymbol = '*';
            char bridgeSymbol = '|';
            char backgroundSymbol = ' ';

            string bridge = new string(bridgeSymbol, n);
            string glasses = frameSymbol + new string(lensesSymbol, 2 * n - 2) + frameSymbol;
            string frame = new string(frameSymbol, 2 * n);
            string background = new string(backgroundSymbol, n);

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                    Console.WriteLine("{0}{1}{0}", frame, background);
                else if (i == (n + 1) / 2)
                    Console.WriteLine("{0}{1}{0}", glasses, bridge);
                else
                    Console.WriteLine("{0}{1}{0}", glasses, background);
            }
        }
    }
}
