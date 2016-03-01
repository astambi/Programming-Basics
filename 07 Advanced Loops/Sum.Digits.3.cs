using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Sum_Digits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumDigits = 0;

            for (int i = n; i > 0; i /= 10)
                sumDigits += i % 10;
            Console.WriteLine("{0}", sumDigits);
        }
    }
}