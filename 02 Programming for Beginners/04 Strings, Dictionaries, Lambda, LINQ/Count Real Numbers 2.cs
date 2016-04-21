using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers_2
{
    class Count_Real_Numbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>(); // sorted

            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))
                    counts[number]++;
                else counts[number] = 1; // adds key and assigns key value, i.e. counts.Add(number, 0) && counts[number]++
            }
            foreach (var number in counts.Keys)
                Console.WriteLine($"{number} -> {counts[number]}");
        }
    }
}
