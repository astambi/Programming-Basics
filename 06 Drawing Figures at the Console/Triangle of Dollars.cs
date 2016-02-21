using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Triangle_of_Dollars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = "$";

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(line);
                line += " $";
            }
        }
    }
}