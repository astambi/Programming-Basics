using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ace_of_Diamonds
{
    class Ace_of_Diamonds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //upper border
            string border = new string('*', n);            
            Console.WriteLine(border); 
            //top pattern
            for (int i = 0; i < (n - 2) / 2 + 1; i++) 
            {
                string left = new string('-', (n - 3) / 2 - i) + new string('@', i);
                string right = new string('@', i) + new string('-', (n - 3) / 2 - i);
                Console.WriteLine("*{0}@{1}*", left, right);
            }
            //bottom pattern
            for (int i = (n - 2) / 2 - 1; i >= 0; i--) 
            {
                string left = new string('-', (n - 3) / 2 - i) + new string('@', i);
                string right = new string('@', i) + new string('-', (n - 3) / 2 - i);
                Console.WriteLine("*{0}@{1}*", left, right);
            }
            //bottom border
            Console.WriteLine(border); 
        }
    }
}