using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_2
{
    class Diamond_2
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int n = (width + 1) / 2;
            string border = "*";
            string background = "-";
            string inside = "";
            string outside = "";

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                    outside += background;
                for (int j = 0; j < width - 2 * (n - i) - 2; j++)
                    inside += background;

                if (i == 1)
                {
                    if (width % 2 == 0)
                        Console.WriteLine("{0}{1}{1}{0}", outside, border);
                    else if (width % 2 != 0)
                        Console.WriteLine("{0}{1}{0}", outside, border);
                }
                else if (i == n)
                    Console.WriteLine("{0}{1}{0}", border, inside);
                else
                    Console.WriteLine("{0}{1}{2}{1}{0}", outside, border, inside);
                outside = "";
                inside = "";
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < n - i; j++)
                    outside += background;
                for (int j = 0; j < width - 2 * (n - i) - 2; j++)
                    inside += background;
                if (i == 1)
                {
                    if (width % 2 == 0)
                        Console.WriteLine("{0}{1}{1}{0}", outside, border);
                    else if (width % 2 != 0)
                        Console.WriteLine("{0}{1}{0}", outside, border);
                }
                else
                    Console.WriteLine("{0}{1}{2}{1}{0}", outside, border, inside);
                outside = "";
                inside = "";
            }
        }
    }
}
