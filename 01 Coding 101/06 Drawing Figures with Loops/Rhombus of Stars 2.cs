using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars_2
{
    class Rhombus_of_Stars_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char backgroundSymbol = ' ';
            char starSymbol = '*';
            string starSpace = " *";
            string rhombus = "";

            //upper half
            for (int i = 1; i <= n; i++)
            {
                string background = new string(backgroundSymbol, n - i);
                if (i == 1)
                    rhombus += starSymbol; // first symbol
                else
                    rhombus += starSpace;
                Console.WriteLine("{0}{1}", background, rhombus);
            }
            //lower half
            for (int i = n - 1; i >= 1; i--)
            {
                string background = new string(backgroundSymbol, n - i);
                rhombus = rhombus.Substring(0, rhombus.Length - 2); //trims the last 2 chars " *" from the last string 
                Console.WriteLine("{0}{1}", background, rhombus);
            }
        }
    }
}
