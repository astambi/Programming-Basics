using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars_2
{
    class Triangle_of_Dollars_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = "";
                for (int j = 0; j < i + 1; j++)
                    line += "$ ";
                Console.WriteLine(line);
            }
        }
    }
}