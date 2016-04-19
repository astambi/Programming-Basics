using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_of_N_x_N_Stars
{
    class Rectangle_of_N_x_N_Stars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char starSymbol = '*';

            string line = new string(starSymbol, n);
            for (int i = 0; i < n; i++)
                Console.WriteLine(line);
        }
    }
}
