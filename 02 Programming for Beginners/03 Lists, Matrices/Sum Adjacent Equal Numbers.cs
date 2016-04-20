using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int currentIndex = 0;
            int count = numbers.Count;

            while (currentIndex < count - 1)
            {
                if (numbers[currentIndex] == numbers[currentIndex + 1])
                {
                    numbers[currentIndex] *= 2;
                    numbers.RemoveAt(currentIndex + 1);

                    currentIndex = Math.Max(0, currentIndex - 1);
                    count--;
                }
                else currentIndex++;
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
