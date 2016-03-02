using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Diamond
{
    class Perfect_Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char backgroundSymbol = ' ';
            string insideSymbol = "-*";
            string background = "";
            string inside = "*";

            for (int i = 1; i <= n; i++)
            {
                background = new string(backgroundSymbol, n - i);
                if (i == 1)
                    Console.WriteLine("{0}*{0}", background);
                else
                {
                    inside += insideSymbol;
                    Console.WriteLine("{0}{1}{0}", background, inside);
                }
            }
            for (int i = n - 1; i >= 1; i--)
            {
                background = new string(backgroundSymbol, n - i);
                if (i == 1)
                    Console.WriteLine("{0}*{0}", background, inside);
                else
                {
                    inside = inside.Substring(0, inside.Length - 2);
                    Console.WriteLine("{0}{1}{0}", background, inside);
                }
            }
        }
    }
}
