using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Powers_of_2
{
    class Even_Powers_of_2
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int power2evenX = 1;
            Console.WriteLine("{0}", power2evenX);

            for (int i = 2; i <= x; i += 2)
            {
                power2evenX *= 2 * 2;
                Console.WriteLine("{0}", power2evenX);
            }
        }
    }
}
