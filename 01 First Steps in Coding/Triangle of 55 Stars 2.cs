using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_55_Stars_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 10;

            for (int i = 1; i <= n; ++i)
            {
                string row = new string('*', i);
                Console.WriteLine(row);
            }
        }
    }
}