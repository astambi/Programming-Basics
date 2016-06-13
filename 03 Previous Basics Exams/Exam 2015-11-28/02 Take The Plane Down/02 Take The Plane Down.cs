using System;

class Take_The_Plane_Down
{
    static void Main(string[] args)
    {
        int xHeadquarters = int.Parse(Console.ReadLine());
        int yHeadquarters = int.Parse(Console.ReadLine());
        int distanceToBorder = int.Parse(Console.ReadLine()); // within shooting range
        int numPlanes = int.Parse(Console.ReadLine());
        for (int i = 0; i < numPlanes; i++)
        {
            int xPlane = int.Parse(Console.ReadLine());
            int yPlane = int.Parse(Console.ReadLine());
            int deltaX = Math.Abs(xPlane - xHeadquarters);
            int deltaY = Math.Abs(yPlane - yHeadquarters);
            double distanceToPlane = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            if (distanceToPlane <= distanceToBorder)
                Console.WriteLine("You destroyed a plane at [{0},{1}]", xPlane, yPlane);
        }            
    }
}