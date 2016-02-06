using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string trunk = " | ";

            for (int i = 0; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string stars = new string('*', i);

                Console.WriteLine("{0}{1}{2}{1}", spaces, stars, trunk);
            }
        }
    }
}