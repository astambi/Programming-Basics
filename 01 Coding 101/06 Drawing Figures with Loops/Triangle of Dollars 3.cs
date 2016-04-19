using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars_3
{
    class Triangle_of_Dollars_3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = "";

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                    line += "$";
                else
                    line += " $";
                Console.WriteLine(line);
            }
        }
    }
}
