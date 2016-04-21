using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
    class Largest_3_Numbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            numbers.Sort();
            numbers.Reverse();

            List<double> largestThreeNums = new List<double>(); 
            for (int i = 0; i < Math.Min(3, numbers.Count); i++) // largest 3 numbers or less
                largestThreeNums.Add(numbers[i]);

            Console.WriteLine(string.Join(" ", largestThreeNums));
        }
    }
}