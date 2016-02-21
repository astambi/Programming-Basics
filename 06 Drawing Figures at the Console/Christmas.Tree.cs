using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Christmas_Tree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n + 1; i++)
            {
                for (int j = 0; j <= n - i; j++)
                    Console.Write(" ");
                for (int j = 1; j < i; j++)
                    Console.Write("*");
                Console.Write(" | ");
                for (int j = 1; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
