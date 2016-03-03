using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Illuminati_Lock_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // top row
            string outsideTop = new string('.', n);
            string insideTop =  new string('#', n);
            Console.WriteLine("{0}{1}{0}", outsideTop, insideTop);
            // upper half
            string center = new string('.', n - 2);
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                string outside = new string('.', n - 2 - 2 * i);
                string inside = new string('.', 2 * i);
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", outside, inside, center);
            }
            // lower half
            for (int i = (n - 1) / 2 - 1; i >= 0; i--)
            {
                string outside = new string('.', n - 2 - 2 * i);
                string inside = new string('.', 2 * i);
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", outside, inside, center);
            }
            // bottom row
            Console.WriteLine("{0}{1}{0}", outsideTop, insideTop);
        }
    }
}
