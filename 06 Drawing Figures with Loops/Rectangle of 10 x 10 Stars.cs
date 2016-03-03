using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_of_10_x_10_Stars
{
    class Rectangle_of_10_x_10_Star
    {
        static void Main(string[] args)
        {
            int n = 10;

            string line = new string('*', n);
            for (int i = 0; i < n; i++)
                Console.WriteLine(line);
        }
    }
}
