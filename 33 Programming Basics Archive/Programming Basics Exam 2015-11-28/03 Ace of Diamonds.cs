using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ace_of_Diamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string border = new string('*', n);
            Console.WriteLine(border); //upper border

            for (int i = 0; i < (n - 2) / 2 + 1; i++) //top pattern
            {
                string left = new string('-', (n - 3) / 2 - i) + new string('@', i);
                string right = new string('@', i) + new string('-', (n - 3) / 2 - i);
                Console.WriteLine("*{0}@{1}*", left, right);
            }
            for (int i = (n - 2) / 2 - 1; i >= 0; i--) //bottom pattern
            {
                string left = new string('-', (n - 3) / 2 - i) + new string('@', i);
                string right = new string('@', i) + new string('-', (n - 3) / 2 - i);
                Console.WriteLine("*{0}@{1}*", left, right);
            }
            Console.WriteLine(border); //bottom border
        }
    }
}