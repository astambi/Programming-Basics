using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Square_Frame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string inside = "";

            for (int i = 0; i < n-2; i++)
                inside += "- ";
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                    Console.WriteLine("+ {0}+", inside);
                else
                    Console.WriteLine("| {0}|", inside);
            }
        }
    }
}
