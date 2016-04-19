using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    class InchToCm
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());

            double centimeters = inches * 2.54;
            Console.WriteLine("Centimeters = {0}", centimeters);
        }
    }
}