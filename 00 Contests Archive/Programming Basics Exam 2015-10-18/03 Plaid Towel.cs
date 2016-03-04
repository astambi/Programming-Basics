using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Plaid_Towel
{
    class _03_Plaid_Towel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char background = Console.ReadLine()[0];
            char rhombus = Console.ReadLine()[0];

            string border = new string(background, n) + rhombus + new string(background, 2 * n - 1) + rhombus + new string(background, n);
            string middle = rhombus + new string(background, 2 * n - 1) + rhombus + new string(background, 2 * n - 1) + rhombus;

            Console.WriteLine(border);
            for (int j = 0; j < 2; j++)
            {
                int k = -1;
                for (int i = 1; i <= n - 1; i++)
                {
                    k = k + 2;
                    int l = 2 * n + 2 * i - 2 * k - 3;
                    string patternEdge = new string(background, n - i);
                    string patternK = new string(background, k);
                    string patternL = new string(background, l);
                    string patternTop = patternEdge + rhombus + patternK + rhombus + patternL + rhombus + patternK + rhombus + patternEdge;
                    Console.WriteLine(patternTop);
                }
                Console.WriteLine(middle);

                int p = -1;
                for (int i = 1; i <= n - 1; i++)
                {
                    p = p + 2;
                    int q = (4 * n - 3 - 2 * i - p) / 2;
                    string patternEdge = new string(background, i);
                    string patternQ = new string(background, q);
                    string patternP = new string(background, p);
                    string patternBottom = patternEdge + rhombus + patternQ + rhombus + patternP + rhombus + patternQ + rhombus + patternEdge;
                    Console.WriteLine(patternBottom);
                }
                Console.WriteLine(border);
            }
        }
    }
}
