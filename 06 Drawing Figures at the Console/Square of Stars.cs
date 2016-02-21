using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Square_of_Stars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                Console.Write("*");             // first symbol
                for (int j = 0; j < n-1; ++j)   // n-1 symbols
                    Console.Write(" *");
                Console.WriteLine();
            }
        }
    }
}
