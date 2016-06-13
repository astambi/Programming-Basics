using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Car
{
    class Car
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // even number
            // widthCar = 3*n; heightCar = 3*n/2-1;	
            char starSymbol = '*';
            char backgroundSymbol = '.';
            string outside = "";
            string inside = "";

            // roof, height roof = n/2
            for (int i = n; i >= n / 2; i--)
            {
                outside = new string(backgroundSymbol, i);
                inside = new string(backgroundSymbol, 3 * n - 2 * i - 2);
                if (i == n)
                    inside = new string(starSymbol, 3 * n - 2 * i - 2);
                else if (i == n / 2)
                    outside = new string(starSymbol, i);
                Console.WriteLine("{0}{1}{2}{1}{0}", outside, starSymbol, inside);
            }
            // chassis 		
            inside = new string(backgroundSymbol, 3 * n - 2);
            for (int i = 1; i < n / 2; i++)
            {
                if (i == n / 2 - 1)
                    inside = new string(starSymbol, 3 * n - 2);
                Console.WriteLine("{0}{1}{0}", starSymbol, inside);
            }
            // wheel, height wheel = n/2-1
            outside = new string(backgroundSymbol, n / 2);
            inside = new string(backgroundSymbol, n - 2);
            string insideWheel = new string(backgroundSymbol, n / 2 - 1);
            for (int i = 0; i < n / 2 - 1; i++)
            {
                if (i == n / 2 - 2)
                    insideWheel = new string(starSymbol, n / 2 - 1);
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", outside, starSymbol, insideWheel, inside);
            }
        }
    }
}
