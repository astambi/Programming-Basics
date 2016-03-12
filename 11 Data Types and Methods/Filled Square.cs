using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filled_Square
{
    class Filled_Square
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // width 2*n, height n
            PrintHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
                PrintMiddleRow(n);
            PrintHeaderRow(n);
        }        
        static void PrintHeaderRow(int n)
        {
            string headerRow = new string('-', 2 * n);
            Console.WriteLine(headerRow);
        }        
        static void PrintMiddleRow(int n)
        {
            string middleRow = "";
            for (int i = 0; i < n - 1; i++)
                middleRow += "\\/";
            Console.WriteLine("-{0}-",middleRow);
        }
    }
}
