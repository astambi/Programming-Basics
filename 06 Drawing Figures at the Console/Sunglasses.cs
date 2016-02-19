using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            char frameSymbol = '*';
            char glassSymbol = '/';
            string empty = new string(' ', n);
            string border = new string(frameSymbol, width);
            string glasses = frameSymbol + new string(glassSymbol, width - 2) + frameSymbol;
            string nose = new string('|', n);

            Console.WriteLine("{0}{1}{0}", border, empty);
            for (int i = 1; i <= n - 2; i++)
            {
                if (i == (n - 1) / 2)
                    Console.WriteLine("{0}{1}{0}", glasses, nose);
                else
                    Console.WriteLine("{0}{1}{0}", glasses, empty);
            }
            Console.WriteLine("{0}{1}{0}", border, empty);
        }
    }
}
