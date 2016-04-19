using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array
{
    class Reverse_Array
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Reverse()));

            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Select(int.Parse).Reverse().ToArray()));
        }
    }
}
