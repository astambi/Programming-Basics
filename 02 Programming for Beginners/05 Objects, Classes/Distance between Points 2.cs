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

            public double DistanceTo(Point p)
            {
                int deltaX = Math.Abs(X - p.X);
                int deltaY = Math.Abs(Y - p.Y);
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
        } 
        static void Main(string[] args)
        {
            Point point1 = ReadPoint();
            Point point2 = ReadPoint();

            double distance = point1.DistanceTo(point2);

            Console.WriteLine("{0:f3}",distance);
        }

        static Point ReadPoint()
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            return new Point() {X = coordinates[0],
                                Y = coordinates[1] };
        }
    }
}
