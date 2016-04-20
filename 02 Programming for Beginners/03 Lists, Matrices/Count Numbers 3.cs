using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(numbers);

            int currentElement = numbers[0];
            int count = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == currentElement)
                    count++;
                else
                {
                    Console.WriteLine("{0} -> {1}", currentElement, count);
                    count = 1;
                    currentElement = numbers[i];
                }                    
            }
            Console.WriteLine("{0} -> {1}", currentElement, count); // last element & count
        }
    }
}