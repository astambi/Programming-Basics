using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class CtoF
    {
        static void Main(string[] args)
        {
            double celcius = double.Parse(Console.ReadLine());
            double fahrenheit = Math.Round(celcius * 9 / 5 + 32, 2);

            Console.WriteLine(fahrenheit);
        }
    }
}