using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_Precision_12
{
    class Circle_Area_Precision_12
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * radius * radius;
            Console.WriteLine("{0:f12}",circleArea);
        }
    }
}
