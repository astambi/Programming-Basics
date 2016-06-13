using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Volleyball
{
    class _01_Volleyball
    {
        static void Main(string[] args)
        {
            string leapYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsTravelling = int.Parse(Console.ReadLine());
            double footballTimes = 0;

            // 48 weekends in a year		
            footballTimes = holidays * 2 / 3.00
                            + (48 - weekendsTravelling) * 1 * 3 / 4.00
                            + weekendsTravelling * 1;
            if (leapYear == "leap") // leap year
                footballTimes *= 1.15;
            Console.WriteLine(Math.Truncate(footballTimes));
        }
    }
}
