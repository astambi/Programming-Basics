using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string border = new string('*', n);
            string inside = new string(' ', n - 2);

            Console.WriteLine(border);
            for (var i = 2; i <= n - 1; ++i)
                Console.WriteLine("*{0}*", inside);
            Console.WriteLine(border);
        }
    }
}