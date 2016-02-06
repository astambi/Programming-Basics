using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class RadToDeg
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            double deg = Math.Round(180 * rad / Math.PI);
            Console.WriteLine(deg);
        }
    }
}