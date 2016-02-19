using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Rhombus_of_Stars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char backgroundSymbol = ' ';
            string star = "* ";
            string rhombus = "";

            for (int i = 1; i <= n; i++)
            {
                string background = new string(backgroundSymbol, n - i);
                for (int j = 0; j < i; j++)
                    rhombus += star;
                Console.WriteLine("{0}{1}", background, rhombus);
                rhombus = "";
            }
            for (int i = n - 1; i >= 1; i--)
            {
                string background = new string(backgroundSymbol, n - i);
                for (int j = 0; j < i; j++)
                    rhombus += star;
                Console.WriteLine("{0}{1}", background, rhombus);
                rhombus = "";
            }
        }
    }
}
