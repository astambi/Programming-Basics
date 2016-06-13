using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Simple_Calculation
{
    class _01_Simple_Calculation
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int resultCartesian = 0;

            if (x > 0 && y > 0)
                resultCartesian = 1;
            else if (x < 0 && y > 0)
                resultCartesian = 2;
            else if (x < 0 && y < 0)
                resultCartesian = 3;
            else if (x > 0 && y < 0)
                resultCartesian = 4;
            else if (x == 0 && y != 0)
                resultCartesian = 5;
            else if (x != 0 && y == 0)
                resultCartesian = 6;

            Console.WriteLine(resultCartesian);
        }
    }
}
