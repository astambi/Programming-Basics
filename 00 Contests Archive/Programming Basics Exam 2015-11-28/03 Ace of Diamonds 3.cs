using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ace_of_Diamonds_3
{
    class Ace_of_Diamonds_3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //upper border
            string border = new string('*', n);
            Console.WriteLine(border);
            //top pattern
            string inside = "@";
            for (int i = 0; i < (n - 2) / 2 + 1; i++)
            {
                string background = new string('-', (n - 3) / 2 - i);
                Console.WriteLine("*{0}{1}{0}*", background, inside);
                inside += "@@";
            }
            //bottom pattern
            inside = inside.Substring(0, inside.Length - 2);
            for (int i = (n - 2) / 2 - 1; i >= 0; i--)
            {
                inside = inside.Substring(0, inside.Length - 2);
                string background = new string('-', (n - 3) / 2 - i);
                Console.WriteLine("*{0}{1}{0}*", background, inside);
            }
            //bottom border
            Console.WriteLine(border);
        }
    }
}
