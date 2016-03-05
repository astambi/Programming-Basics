using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Headphones
{
    class Headphones
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // n always odd
            int mid = (n + 1) / 2;
            int width = 2 * n + 1;
            char headphonesSymbol = '*';
            char backgroundSymbol = '-';
            string background = new string(backgroundSymbol, mid - 1);
            string inside = new string(headphonesSymbol, width - 2 * (mid - 1) - 2);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{2}{1}{2}{0}", background, inside, headphonesSymbol);
                inside = new string(backgroundSymbol, width - 2 * (mid - 1) - 2);
            }
            int headphonesCount = -1;
            for (int i = 1; i <= mid; i++)
            {
                headphonesCount += 2;
                background = new string(backgroundSymbol, mid - i);
                string headphones = new string(headphonesSymbol, headphonesCount);
                inside = new string(backgroundSymbol, width - 2 * headphonesCount - 2 * (mid - i));
                Console.WriteLine("{0}{1}{2}{1}{0}", background, headphones, inside);
            }
            for (int i = 1; i < mid; i++)
            {
                headphonesCount -= 2;
                background = new string(backgroundSymbol, i);
                string headphones = new string(headphonesSymbol, headphonesCount);
                inside = new string(backgroundSymbol, width - 2 * headphonesCount - 2 * i);
                Console.WriteLine("{0}{1}{2}{1}{0}", background, headphones, inside);
            }
        }
    }
}
