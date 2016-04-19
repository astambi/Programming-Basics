using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_of_Two
{
    class Powers_of_Two
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int power2X = 1;
            Console.WriteLine(power2X);
            for (int i = 1; i <= x; i++)
            {
                power2X *= 2;
                Console.WriteLine(power2X);
            }
        }
    }
}
