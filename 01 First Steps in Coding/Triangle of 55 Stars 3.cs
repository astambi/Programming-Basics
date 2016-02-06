using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_55_Stars_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            for (var star = "*"; star.Length <= n; star += "*")
                Console.WriteLine(star);
        }
    }
}