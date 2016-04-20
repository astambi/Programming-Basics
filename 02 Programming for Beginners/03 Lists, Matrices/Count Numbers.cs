using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            // no sorting 

            int[] count = new int[numbers.Max() + 1]; // quite slow, too many empty counts
            foreach (var number in numbers)
                count[number]++;

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                    Console.WriteLine("{0} -> {1}", i, count[i]);
            }
        }
    }
}
