using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Triangle
{
    class _01_Triangle
    {
        static void Main(string[] args)
        {
            int aX = int.Parse(Console.ReadLine());
            int aY = int.Parse(Console.ReadLine());
            int bX = int.Parse(Console.ReadLine());
            int bY = int.Parse(Console.ReadLine());
            int cX = int.Parse(Console.ReadLine());
            int cY = int.Parse(Console.ReadLine());
            double areaTriangle = 0;

            // sides
            double sideA = Math.Pow(Math.Abs(bY - cY), 2) +
                            Math.Pow(Math.Abs(bX - cX), 2);
            double sideB = Math.Pow(Math.Abs(aY - cY), 2) +
                            Math.Pow(Math.Abs(aX - cX), 2);
            double sideC = Math.Pow(Math.Abs(aY - bY), 2) +
                            Math.Pow(Math.Abs(aX - bX), 2);
            sideA = Math.Sqrt(sideA);
            sideB = Math.Sqrt(sideB);
            sideC = Math.Sqrt(sideC);

            bool isTriangle = (sideA + sideB > sideC) &&
                                (sideA + sideC > sideB) &&
                                (sideB + sideC > sideA);
            if (isTriangle)
            {
                double perimeter = (sideA + sideB + sideC) / 2.00;
                areaTriangle = perimeter *
                                (perimeter - sideA) *
                                (perimeter - sideB) *
                                (perimeter - sideC);
                areaTriangle = Math.Sqrt(areaTriangle);
                Console.WriteLine("Yes\n{0:0.00}", areaTriangle);
            }
            else
                Console.WriteLine("No\n{0:0.00}", sideC);
        }
    }
}
