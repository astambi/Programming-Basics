using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars_2
{
    class Square_of_Stars_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string line = "";
            for (int i = 0; i < n; ++i)
                line += "* ";
            for (int i = 0; i < n; ++i)
                Console.WriteLine(line);
        }
    }
}
