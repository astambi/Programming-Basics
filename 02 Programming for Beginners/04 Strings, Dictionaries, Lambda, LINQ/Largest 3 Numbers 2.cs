using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers_2
{
    class Largest_3_Numbers
    {
        static void Main(string[] args)
        {
            double[] largestThreeNums = Console.ReadLine().Split(' ').Select(double.Parse)
                                        .OrderBy(x => -x) // descending order
                                        .Take(3)
                                        .ToArray();

            Console.WriteLine(string.Join(" ", largestThreeNums));
        }
    }
}
