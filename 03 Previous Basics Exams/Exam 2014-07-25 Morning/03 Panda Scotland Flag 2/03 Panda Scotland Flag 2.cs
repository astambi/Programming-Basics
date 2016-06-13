using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Panda_Scotland_Flag_2
{
    class Panda_Scotland_Flag
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // always odd
            int mid = (n + 1) / 2;
            char insideSymbol = '#';
            char outsideSymbol = '~';
            char midSymbol = '-';
            char letterL = 'A';
            char letterR = 'A';
            string inside = "";
            string outside = "";

            // top
            for (int i = 1; i < mid; i++)
            {
                inside = new string(insideSymbol, n - 2 * i);
                outside = new string(outsideSymbol, i - 1);
                letterR = GetNextLetter(letterL);
                Console.WriteLine("{0}{1}{2}{3}{0}", outside, letterL, inside, letterR);
                letterL = GetNextLetter(letterR);
            }
            // mid
            outside = new string(midSymbol, mid - 1);
            Console.WriteLine("{0}{1}{0}", outside, letterL);
            letterR = letterL;
            // bottom
            for (int i = mid - 1; i >= 1; i--)
            {
                inside = new string(insideSymbol, n - 2 * i);
                outside = new string(outsideSymbol, i - 1);
                letterL = GetNextLetter(letterR);
                letterR = GetNextLetter(letterL);
                Console.WriteLine("{0}{1}{2}{3}{0}", outside, letterL, inside, letterR);
            }
        }

        static char GetNextLetter(char previousLetter)
        {
            char nextLetter = (char)((int)previousLetter + 1);
            if (nextLetter > 'Z') nextLetter = 'A';
            return nextLetter;
        }
    }
}
