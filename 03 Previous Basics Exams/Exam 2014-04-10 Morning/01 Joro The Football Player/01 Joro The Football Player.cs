using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Joro_The_Football_Player
{
    class _01_Joro_The_Football_Player
    {
        static void Main(string[] args)
        {
            string leapYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsTravelling = int.Parse(Console.ReadLine());
            double footballTimes = 0;

            // 52 weekends in a year		
            footballTimes = holidays / 2.00
                            + (52 - weekendsTravelling) * 2 / 3.00
                            + weekendsTravelling * 1;
            if (leapYear == "t") // leap year
                footballTimes += 3;
            Console.WriteLine(Math.Truncate(footballTimes));
        }
    }
}
