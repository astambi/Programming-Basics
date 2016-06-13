using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_House_with_a_Window
{
    class House_with_a_Window
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int height = 2 * n + 2;
            int windowWidth = n - 3;

            char starSymbol = '*';
            char backgroundSymbol = '.';
            string background = "";
            string inside = "";
            string window = new string(starSymbol, windowWidth);

            // roof height = n
            for (int i = 0; i < n; i++)
            {
                background = new string(backgroundSymbol, n - 1 - i);
                if (i == 0)
                    Console.WriteLine("{0}{1}{0}", background, starSymbol);
                else
                {
                    inside = new string(backgroundSymbol, 2 * i - 1);
                    Console.WriteLine("{0}{1}{2}{1}{0}", background, starSymbol, inside);
                }
            }
            // base height = n+2; window height = n/2; window width = n-3	
            for (int i = 0; i < n + 2; i++)
            {
                if (i == 0 || i == n + 1) // first & last rows
                {
                    inside = new string(starSymbol, 2 * n - 3);
                    Console.WriteLine("{0}{1}{0}", starSymbol, inside);
                }
                else if (i > (n + 2) / 4 && i < (n + 2) * 3 / 4) // window
                {
                    inside = new string(backgroundSymbol, n / 2);
                    Console.WriteLine("{0}{1}{2}{1}{0}", starSymbol, inside, window);
                }
                else
                {
                    inside = new string(backgroundSymbol, 2 * n - 3);
                    Console.WriteLine("{0}{1}{0}", starSymbol, inside);
                }
            }
        }
    }
}
