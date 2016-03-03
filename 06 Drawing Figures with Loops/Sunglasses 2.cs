using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses_2
{
    class Sunglasses_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            char frameSymbol = '*';
            char glassSymbol = '/';
            char noseSymbol = '|';
            char backgroundSymbol = ' ';

            string background = new string(backgroundSymbol, n);
            string frame = new string(frameSymbol, width);
            string glasses = frameSymbol + new string(glassSymbol, width - 2) + frameSymbol;
            string nose = new string(noseSymbol, n);

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n) // first & last rows
                    Console.WriteLine("{0}{1}{0}", frame, background);
                else if (i == (n + 1) / 2) //middle row
                    Console.WriteLine("{0}{1}{0}", glasses, nose);
                else
                    Console.WriteLine("{0}{1}{0}", glasses, background);
            }
        }
    }
}
