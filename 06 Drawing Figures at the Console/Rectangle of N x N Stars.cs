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
            string line = new string('*', n);
            for (int i = 0; i < n; i++)
                Console.WriteLine(line);
        }
    }
}
