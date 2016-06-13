using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Electricity
{
    class Electricity
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int flatsPerFloor = int.Parse(Console.ReadLine());
            string timeInput = Console.ReadLine();
            double wattsLamp = 100.53;
            double wattsComputer = 125.90;
            int lamps = 0;
            int computers = 0;

            string[] splitInput = timeInput.Split(':');
            int hour = int.Parse(splitInput[0]);
            int minute = int.Parse(splitInput[1]);

            bool afternoon = hour >= 14 && hour <= 18;
            bool evening = hour >= 19 && hour <= 23;
            bool night = hour >= 0 && hour <= 8;
            if (afternoon)
            {
                lamps = 2;
                computers = 2;
            }
            else if (evening)
            {
                lamps = 7;
                computers = 6;
            }
            else if (night)
            {
                lamps = 1;
                computers = 8;
            }
            double totalWatts = (lamps * wattsLamp + computers * wattsComputer) 
                                * flatsPerFloor * floors;
            Console.WriteLine("{0} Watts", Math.Truncate(totalWatts));
        }
    }
}
