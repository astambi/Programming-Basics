using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_New_House
{
    class _03_New_House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mid = (n + 1) / 2;
            char houseSymbol = '*';
            char outsideSymbol = '-';
            string house = "*";
            string outside = "";

            // roof
            for (int i = 0; i < mid; i++)
            {
                outside = new string(outsideSymbol, (n - 1) / 2 - i);
                Console.WriteLine("{0}{1}{0}", outside, house);
                house += new string(houseSymbol, 2);
            }
            // house
            house = new string(houseSymbol, n - 2);
            for (int i = 0; i < n; i++)
                Console.WriteLine("|{0}|", house);
        }
    }
}
