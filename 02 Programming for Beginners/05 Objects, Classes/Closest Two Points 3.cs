using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Two_Points
{
    class Closest_Two_Points
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public double DistanceTo (Point p)
            {
                int deltaX = Math.Abs(X - p.X);
                int deltaY = Math.Abs(Y - p.Y);
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
        }

        static void Main(string[] args)
        {
            Point[] points = GetPoints();
            // get points
            List<Point> closestPoints = new List<Point>();
            double minDistance = double.MaxValue;
            // calc min distance
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = points[i].DistanceTo(points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestPoints.Clear();
                        closestPoints.Add(points[i]);
                        closestPoints.Add(points[j]);
                    }
                }
            }
            // print result
            Console.WriteLine("{0:f3}", minDistance);
            PrintPoints(closestPoints);
        }

        static void PrintPoints(List<Point> points)
        {
            for (int i = 0; i < points.Count; i++)
                Console.WriteLine("({0}, {1})", points[i].X, points[i].Y);
        }

        static Point[] GetPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                points[i] = new Point() { X = coordinates[0],
                                          Y = coordinates[1] };
            }
            return points;
        }
    }
}
