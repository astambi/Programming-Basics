using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Panda_Scotland_Flag
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
                letterR = (char)((int)letterL + 1);
                if (letterR > 'Z') letterR = 'A';
                Console.WriteLine("{0}{1}{2}{3}{0}", outside, letterL, inside, letterR);

                letterL = (char)((int)letterR + 1);
                if (letterL > 'Z') letterL = 'A';
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
                letterL = (char)((int)letterR + 1);
                if (letterL > 'Z') letterL = 'A';
                letterR = (char)((int)letterL + 1);
                if (letterR > 'Z') letterR = 'A';
                Console.WriteLine("{0}{1}{2}{3}{0}", outside, letterL, inside, letterR);
            }
        }
    }
}
