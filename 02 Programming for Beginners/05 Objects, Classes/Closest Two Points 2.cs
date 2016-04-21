using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Two_Points_2
{
    class Closest_Two_Points_2
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static void Main(string[] args)
        {
            Point[] points = GetPoints();
            Point[] closestPoints = FindClosestTwoPoints(points);

            PrintDistance(closestPoints);
            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        static void PrintDistance(Point[] closestPoints)
        {
            Console.WriteLine("{0:f3}", CalcDistance(closestPoints[0], closestPoints[1]));
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            Point[] closestPoints = null;
            double minDistance = double.MaxValue;

            for (int i = 0; i < points.Length; i++)
                for (int j = i + 1; j < points.Length; j++)
                {
                    double currentDistance = CalcDistance(points[i], points[j]);
                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        closestPoints = new Point[] { points[i], points[j] };
                    }
                }
            return closestPoints;
        }

        static Point[] GetPoints()
        {
            int numPoints = int.Parse(Console.ReadLine());
            Point[] points = new Point[numPoints];

            for (int i = 0; i < numPoints; i++)
                points[i] = ReadPoint();
            return points;
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