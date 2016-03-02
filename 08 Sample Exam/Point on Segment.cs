using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_Segment
{
    class Point_on_Segment
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            bool pointOnSegment = point >= Math.Min(first, second) && point <= Math.Max(first, second);
            int closerDistance = Math.Min(Math.Abs(first - point), Math.Abs(second - point));

            if (pointOnSegment)
                Console.WriteLine("in");
            else
                Console.WriteLine("out");
            Console.WriteLine(closerDistance);
        }
    }
}
