using System;
using System.Linq;

class Teleport_Points
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    class Rectangle
    {
        public Point A { get; set; }    // bottom left
        public Point B { get; set; }    // bottom right
        public Point C { get; set; }    // top right
        public Point D { get; set; }    // top left
        public bool Contains(double x, double y)
        {
            return x > A.X && x < B.X && y > A.Y && y < D.Y;
        }
    }

    static void Main(string[] args)
    {
        Rectangle room = new Rectangle() { A = GetPoint(), B = GetPoint(), C = GetPoint(), D = GetPoint() };
        double radius = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());
        int positionsCount = 0;
        for (double x = 0; x <= radius; x += step)
        {
            for (double y = 0; y <= radius; y += step)
                if (room.Contains(x, y) && Math.Sqrt(x * x + y * y) <= radius)
                    positionsCount++;
            for (double y = -step; y >= -radius; y -= step)
                if (room.Contains(x, y) && Math.Sqrt(x * x + y * y) <= radius)
                    positionsCount++;
        }
        for (double x = -step; x >= -radius; x -= step)
        {
            for (double y = 0; y <= radius; y += step)
                if (room.Contains(x, y) && Math.Sqrt(x * x + y * y) <= radius)
                    positionsCount++;
            for (double y = -step; y >= -radius; y -= step)
                if (room.Contains(x, y) && Math.Sqrt(x * x + y * y) <= radius)
                    positionsCount++;
        }
        Console.WriteLine(positionsCount);
    }

    static Point GetPoint()
    {
        double[] coordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        return new Point() { X = coordinates[0], Y = coordinates[1] };
    }
}