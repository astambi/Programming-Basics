using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            int index = 0;
            while (index < numbers.Count - 1)
            {
                if (numbers[index] == numbers[index + 1])
                {
                    numbers[index] *= 2;
                    numbers.RemoveAt(index + 1);

                    index = Math.Max(0, index - 1);
                }
                else index++;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
