using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars_3
{
    class Square_of_Stars_3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)     // rows
            {
                for (int j = 0; j < n; ++j) // columns
                {
                    if (j == 0)             // first symbol
                        Console.Write("*");
                    else 
                        Console.Write(" *"); 
                }
                Console.WriteLine();
            }
        }
    }
}
