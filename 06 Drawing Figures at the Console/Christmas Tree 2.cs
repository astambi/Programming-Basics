using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree_2
{
    class Christmas_Tree_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string stars = new string('*', i);
                Console.WriteLine("{0}{1} | {1}", spaces, stars);
            }
        }
    }
}
