using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double volumeCart = double.Parse(Console.ReadLine());

            double shipments = Math.Ceiling(bricks / (workers * volumeCart));

            Console.WriteLine(shipments);
        }
    }
}
