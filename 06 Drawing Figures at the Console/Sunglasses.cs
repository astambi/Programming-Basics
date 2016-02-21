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
            char noseSymbol = '|';
            char backgroundSymbol = ' ';

            string background = new string(backgroundSymbol, n);
            string frame = new string(frameSymbol, width);
            string glasses = frameSymbol + new string(glassSymbol, width - 2) + frameSymbol;
            string nose = new string(noseSymbol, n);

            Console.WriteLine("{0}{1}{0}", frame, background); //first row
            for (int i = 1; i <= n - 2; i++)
            {
                if (i == (n - 1) / 2) //middle row
                    Console.WriteLine("{0}{1}{0}", glasses, nose);
                else
                    Console.WriteLine("{0}{1}{0}", glasses, background);
            }
            Console.WriteLine("{0}{1}{0}", frame, background); //last row
        }
    }
}
