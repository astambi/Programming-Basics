using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;
            double circumference = 2 * Math.PI * r;

            Console.WriteLine(area);
            Console.WriteLine(circumference);
        }
    }
}