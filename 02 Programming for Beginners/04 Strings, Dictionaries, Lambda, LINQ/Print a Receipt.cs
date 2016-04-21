using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_a_Receipt
{
    class Print_a_Receipt
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int len = 24;
            string border = new string('-', len - 2);

            Console.WriteLine("/{0}\\", border);
            foreach (var number in numbers)
                Console.WriteLine("| {0,20:f2} |", number);
            Console.WriteLine("|{0}|", border);
            Console.WriteLine("| Total:{0,14:f2} |", numbers.Sum());
            Console.WriteLine("\\{0}/", border);
        }
    }
}
