using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Grand_Theft_Examo
{
    class _02_Grand_Theft_Examo
    {
        static void Main(string[] args)
        {
            int escapeAttempts = int.Parse(Console.ReadLine());
            double beers = 0;
            double thieves = 0;
            double thievesSlapped = 0;
            double thievesEscaped = 0;

            for (int i = 0; i < escapeAttempts; i++)
            {
                thieves = double.Parse(Console.ReadLine());
                beers += double.Parse(Console.ReadLine());

                thievesSlapped += Math.Min(5, thieves);             //slaps max 5 thieves per escape attempt
                thievesEscaped += thieves - Math.Min(5, thieves);
            }

            double beers6packs = Math.Truncate(beers / 6);
            double beersBottles = beers % 6;

            Console.WriteLine("{0} thieves slapped.", thievesSlapped);
            Console.WriteLine("{0} thieves escaped.", thievesEscaped);
            Console.WriteLine("{0} packs, {1} bottles.", beers6packs, beersBottles);
        }
    }
}
