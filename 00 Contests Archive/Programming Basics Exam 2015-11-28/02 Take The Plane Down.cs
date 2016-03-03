using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Take_The_Plane_Down
{
    class Take_The_Plane_Down
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int distanceToBorder = int.Parse(Console.ReadLine()); // within shooting range
            int numPlanes = int.Parse(Console.ReadLine());

            int[] xPlane = new int[numPlanes];
            int[] yPlane = new int[numPlanes];

            for (int i = 0; i < numPlanes; i++)
            {
                xPlane[i] = int.Parse(Console.ReadLine());
                yPlane[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numPlanes; i++)
            {
                double distanceToPlane = Math.Sqrt(Math.Pow(xPlane[i] - x, 2) + Math.Pow(yPlane[i] - y, 2));
                if (distanceToPlane <= distanceToBorder)
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", xPlane[i], yPlane[i]);
            }
        }
    }
}