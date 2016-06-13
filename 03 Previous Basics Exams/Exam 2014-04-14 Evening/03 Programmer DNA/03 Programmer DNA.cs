using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Programmer_DNA
{
    class _03_Programmer_DNA
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char letter = Console.ReadLine().ToUpper()[0]; // [A,G]
            char backgroundSymbol = '.';
            string background = "";
            string DNA = "";
            int widthDNA = 7;
            int[] lettersPerLine = { 1, 3, 5, 7, 5, 3, 1 };

            for (int i = 0; i < n; i++)
            {
                background = new string(backgroundSymbol, (widthDNA - lettersPerLine[i % 7]) / 2);
                DNA = "";
                for (int j = 0; j < lettersPerLine[i % 7]; j++)
                {
                    DNA += letter;
                    letter++;
                    if (letter > 'G') letter = 'A';
                }
                Console.WriteLine("{0}{1}{0}", background, DNA);
            }
        }
    }
}