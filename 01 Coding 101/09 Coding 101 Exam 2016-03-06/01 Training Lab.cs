using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Training_Lab
{
    class Training_Lab
    {
        static void Main(string[] args)
        {
            double height = 100 * double.Parse(Console.ReadLine()); // cm
            double width = 100 * double.Parse(Console.ReadLine());  // cm

            double netWidth = width - 100;                          // cm
            double desksPerRow = Math.Truncate(netWidth / 70);

            double netHeight = height;
            double deskRows = Math.Truncate(netHeight / 120);

            double desks = deskRows * desksPerRow;
            desks -= 3;                                             // less space for door & front desk

            Console.WriteLine(desks);
        }
    }
}
