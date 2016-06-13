using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Star
{
    class Star
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // always even number
            int width = 2 * n + 1;                  // height =  2*n - n/2 + 1;
            int heightMid = n / 2;                  // heightLeg = n/2 + 1;
            char starSymbol = '*';
            char backgroundSymbol = '.';
            string outside = "";
            string inside = "";

            // top		
            for (int i = 0; i < heightMid; i++)
            {
                outside = new string(backgroundSymbol, n - i);
                if (i == 0)
                    Console.WriteLine("{0}{1}{0}", outside, starSymbol);
                else
                {
                    inside = new string(backgroundSymbol, width - 2 - 2 * (n - i));
                    Console.WriteLine("{0}{1}{2}{1}{0}", outside, starSymbol, inside);
                }
            }
            // mid shoulders
            outside = new string(starSymbol, n / 2 + 1);
            inside = new string(backgroundSymbol, n - 1);
            Console.WriteLine("{0}{1}{0}", outside, inside);
            // upper mid 
            for (int i = 1; i <= heightMid; i++)
            {
                outside = new string(backgroundSymbol, i);

                if (i != heightMid)
                {
                    inside = new string(backgroundSymbol, width - 2 - 2 * i);
                    Console.WriteLine("{0}{1}{2}{1}{0}", outside, starSymbol, inside);
                }
                else
                {
                    inside = new string(backgroundSymbol, (width - 3 - 2 * i) / 2);
                    Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", outside, starSymbol, inside);
                }
            }
            // lower mid
            int countInside = 1;
            int countInsideLeg = n / 2 - 1;
            string insideLeg = new string(backgroundSymbol, countInsideLeg);
            for (int i = heightMid - 1; i >= 1; i--)
            {
                outside = new string(backgroundSymbol, i);
                inside = new string(backgroundSymbol, countInside);
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", outside, starSymbol, insideLeg, inside);
                countInside += 2;
            }
            // bottom		
            inside = new string(backgroundSymbol, countInside);
            outside = new string(starSymbol, (width - countInside) / 2);
            Console.WriteLine("{0}{1}{0}", outside, inside);
        }
    }
}
