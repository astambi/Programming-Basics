using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();

            int count = 1;
            int currentNumber = numbers[0];
            for (int i = 1; i < numbers.Count + 1; i++)
            {
                if (i == numbers.Count)
                    Console.WriteLine("{0} -> {1}", currentNumber, count); // print last number & count
                else if (currentNumber == numbers[i])
                    count++;
                else
                {
                    Console.WriteLine("{0} -> {1}", currentNumber, count);
                    currentNumber = numbers[i];
                    count = 1;
                }
            }
        }
    }
}
