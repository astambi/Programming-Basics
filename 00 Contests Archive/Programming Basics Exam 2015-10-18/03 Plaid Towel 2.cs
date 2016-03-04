using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Plaid_Towel_2
{
    class Plaid_Towel_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char background = Console.ReadLine()[0];
            char rhombus = Console.ReadLine()[0];
            int width = 4 * n + 1;

            // top row
            string outsideTop = new string(background, n);
            string insideTop = new string(background, 2 * n - 1);
            string insideMiddle = new string(background, 2 * n - 1);
            Console.WriteLine("{0}{1}{2}{1}{0}", outsideTop, rhombus, insideTop);

            for (int j = 0; j < 2; j++)
            {
                // upper half
                int countInside1 = -1;
                int countInside2 = 2 * n - 1;
                for (int i = 1; i <= n - 1; i++)
                {
                    countInside1 += 2;
                    countInside2 -= 2;
                    string patternEdge = new string(background, n - i);
                    string patternInside1 = new string(background, countInside1);
                    string patternInside2 = new string(background, countInside2);
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", patternEdge, rhombus, patternInside1, patternInside2);
                }
                // middle
                Console.WriteLine("{0}{1}{0}{1}{0}", rhombus, insideMiddle);
                // lower half
                countInside1 = (width - 3 ) / 2;
                countInside2 = -1;
                for (int i = 1; i <= n - 1; i++)
                {
                    countInside1 -= 2;
                    countInside2 += 2;
                    string patternEdge = new string(background, i);
                    string patternInside1 = new string(background, countInside1);
                    string patternInside2 = new string(background, countInside2);
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", patternEdge, rhombus, patternInside1, patternInside2);
                }
                // bottom row
                Console.WriteLine("{0}{1}{2}{1}{0}", outsideTop, rhombus, insideTop);
            }
        }
    }
}
