using System;

class Take_The_Plane_Down
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
        Point headquarters = new Point() { X = int.Parse(Console.ReadLine()),
                                            Y = int.Parse(Console.ReadLine()) };
        int distanceToBorder = int.Parse(Console.ReadLine());   // shooting range
        int numPlanes = int.Parse(Console.ReadLine());
        for (int i = 0; i < numPlanes; i++)
        {
            Point plane = new Point() { X = int.Parse(Console.ReadLine()),
                                        Y = int.Parse(Console.ReadLine())};
            double distanceToPlane = headquarters.DistanceTo(plane);
            if (distanceToPlane <= distanceToBorder)
                Console.WriteLine("You destroyed a plane at [{0},{1}]", plane.X, plane.Y);
        }
    }
}