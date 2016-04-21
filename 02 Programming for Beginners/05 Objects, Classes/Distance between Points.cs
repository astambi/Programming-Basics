using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_between_Points
{
    class Distance_between_Points
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static void Main(string[] args)
        {
            Point point1 = ReadPoint();
            Point point2 = ReadPoint();

            double distance = CalcDistance(point1, point2);

            Console.WriteLine("Distance: {0:f3}", distance);
        }

        static Point ReadPoint()
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            return new Point() { X = coordinates[0],
                                 Y = coordinates[1] };
        }

        static double CalcDistance(Point point1, Point point2)
        {
            int deltaX = Math.Abs(point2.X - point1.X);
            int deltaY = Math.Abs(point2.Y - point1.Y);
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}