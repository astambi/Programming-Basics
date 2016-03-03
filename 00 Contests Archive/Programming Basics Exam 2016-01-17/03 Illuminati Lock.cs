using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Illuminati_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string horizontalBorder = new string('.', n) + new string('#', n) + new string('.', n);
            Console.WriteLine(horizontalBorder);

            string center = new string('#', 1) + new string('.', n - 2) + new string('#', 1);
            for (int i = 0; i < (n-1)/2; i++)
            {
                string left = new string('.', n - 2 - 2*i) + new string('#', 2) + new string('.', 2*i);
                string right = new string('.', 2*i) +  new string('#', 2) + new string('.', n - 2 - 2*i);
                Console.WriteLine("{0}{1}{2}", left, center, right);
            }
            for (int i = (n-1)/2 - 1; i >= 0; i--)
            {
                string left = new string('.', n - 2 - 2 * i) + new string('#', 2) + new string('.', 2 * i);
                string right = new string('.', 2 * i) + new string('#', 2) + new string('.', n - 2 - 2 * i);
                Console.WriteLine("{0}{1}{2}", left, center, right);
            }
            Console.WriteLine(horizontalBorder);
        }
    }
}