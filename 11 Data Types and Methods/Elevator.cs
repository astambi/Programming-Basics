using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling( (double)persons / capacity);
            //int courses = (int)Math.Ceiling(1.00 * persons / capacity);
            //double courses = Math.Ceiling( (double)persons / capacity);

            Console.WriteLine(courses);
        }
    }
}
