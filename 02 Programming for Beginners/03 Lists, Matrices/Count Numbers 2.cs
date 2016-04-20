using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();

            int currentIndex = 0;
            while (currentIndex < numbers.Count)
            {
                int currentNumber = numbers[currentIndex];
                int count = 1;

                while (currentIndex + count < numbers.Count && currentNumber == numbers[currentIndex + count])
                    count++;

                Console.WriteLine("{0} -> {1}", currentNumber, count);
                currentIndex += count;
            }
        }
    }
}
