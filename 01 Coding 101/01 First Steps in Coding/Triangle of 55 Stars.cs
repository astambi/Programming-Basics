using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_55_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            for (var i = 1; i <= n; ++i)
            {
                for (var j = 1; j <= i; ++j)
                    Console.Write("*");
                Console.WriteLine();
            }            
        }
    }
}