using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double horizontal = Math.Abs(x2 - x1);
            double vertical = Math.Abs(y2 - y1);
            double area = horizontal * vertical;
            double circumference = 2 * (horizontal + vertical);

            Console.WriteLine(area);
            Console.WriteLine(circumference);
        }            
    }
}