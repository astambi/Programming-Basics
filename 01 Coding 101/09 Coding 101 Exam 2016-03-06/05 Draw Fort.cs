using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Draw_Fort
{
    class Draw_Fort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int height = n;
            int peakWidth = n / 2;
            char backgroundSymbol = ' ';
            char bottomSymbol = '_';
            char peakSymbol = '^';
            string inside = "";
            string peak = "";

            // peaks
            peak = new string(peakSymbol, peakWidth);
            inside = new string(bottomSymbol, width - 4 - 2 * peakWidth);
            Console.WriteLine("/{0}\\{1}/{0}\\", peak,inside);

            // middle
            for (int i = 1; i < height - 2; i++)
            {
                inside = new string(backgroundSymbol, width - 2);
                Console.WriteLine("|{0}|",inside);
            }

            // bottom top
            inside = new string(backgroundSymbol, peakWidth + 1);
            peak = new string(bottomSymbol, width - 2 * peakWidth - 4);
            Console.WriteLine("|{0}{1}{0}|", inside, peak);

            // bottom
            peak = new string(bottomSymbol, peakWidth);
            inside = new string(backgroundSymbol, width - 4 - 2 * peakWidth);
            Console.WriteLine("\\{0}/{1}\\{0}/",peak, inside);
        }
    }
}
