using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_with_Stars
{
    class Rectangle_with_Stars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int mid = n - n / 2;
            char borderSymbol = '%';
            char backgroundSymbol = ' ';

            // first row
            string border = new string(borderSymbol, width);
            Console.WriteLine(border);
            // body
            for (int i = 1; i <= mid; i++)
            {
                if (i == mid)   // mid row with 2 stars
                {
                    string inside = new string(backgroundSymbol, (width - 4) / 2);
                    Console.WriteLine("{0}{1}**{1}{0}", borderSymbol, inside);
                }
                else
                {
                    string inside = new string(backgroundSymbol, width - 2);
                    Console.WriteLine("{0}{1}{0}", borderSymbol, inside);
                }
            }
            for (int i = 1; i < mid; i++)
            {
                string inside = new string(backgroundSymbol, width - 2);
                Console.WriteLine("{0}{1}{0}", borderSymbol, inside);
            }
            //last row
            Console.WriteLine(border);      
        }
    }
}
