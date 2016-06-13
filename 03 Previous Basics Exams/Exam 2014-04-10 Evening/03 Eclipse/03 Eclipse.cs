using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Eclipse
{
    class _03_Eclipse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // always odd
            int width = 5 * n - 1;
            char lensesSymbol = '/';
            char frameSymbol = '*';
            char bridgeSymbol = '-';
            char backgroundSymbol = ' ';

            string glasses = frameSymbol + new string(lensesSymbol, 2 * n - 2) + frameSymbol;
            string frame = backgroundSymbol + new string(frameSymbol, 2 * n - 2) + backgroundSymbol;
            string bridge = new string(bridgeSymbol, n - 1);
            string background = new string(backgroundSymbol, n - 1);

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
