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

            string left = "";
            string right = "";
            string center = "";
            string horizontalBorder = new string('.', n) + new string('#', n) + new string('.', n);

            Console.WriteLine(horizontalBorder);

            for (int i = 0; i < (n-1)/2; i++)
            {
                left = new string('.', n - 2 - 2*i) + new string('#', 2) + new string('.', 2*i); 
                right = new string('.', 2*i) +  new string('#', 2) + new string('.', n - 2 - 2*i);
                center =  new string('#',1) + new string('.',n-2) + new string('#',1);
                Console.WriteLine("{0}{1}{2}", left, center, right);
            }

            for (int i = (n-1)/2 - 1; i >= 0; i--)
            {
                left = new string('.', n - 2 - 2 * i) + new string('#', 2) + new string('.', 2 * i);
                right = new string('.', 2 * i) + new string('#', 2) + new string('.', n - 2 - 2 * i);
                center = new string('#', 1) + new string('.', n - 2) + new string('#', 1);
                Console.WriteLine("{0}{1}{2}", left, center, right);
            }

            Console.WriteLine(horizontalBorder);
        }
    }
}