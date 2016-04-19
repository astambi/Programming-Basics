using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Min_Number
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int min = number;

            for (int i = 1; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number < min)
                    min = number;
            }
            Console.WriteLine(min);
        }
    }
}
