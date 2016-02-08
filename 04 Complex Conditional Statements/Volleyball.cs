using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsAway = double.Parse(Console.ReadLine());

            double games = 0;

            games = (48 - weekendsAway) * 3 / 4 + holidays * 2 / 3 + weekendsAway;
            if (year == "leap")
                games *= 1.15;

            Console.WriteLine("{0:0}", Math.Truncate(games));
        }
    }
}