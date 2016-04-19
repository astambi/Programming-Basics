using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor__CGD_
{
    class Greatest_Common_Divisor_CGD
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            // Euclid's algorithm
            while (b != 0) 
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            Console.WriteLine(a); // GCD 
        }
    }
}
