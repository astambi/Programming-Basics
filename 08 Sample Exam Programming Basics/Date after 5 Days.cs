using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_after_5_Days
{
    class Date_after_5_Days
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());    // [1,31]
            int month = int.Parse(Console.ReadLine());  // [1,12]

            bool daysInMonth30 = month == 4 || month == 6 || month == 9 || month == 11;
            bool daysInMonth28 = month == 2;

            int daysInMonth = 31;
            if (daysInMonth30)
                daysInMonth = 30;
            else if (daysInMonth28)
                daysInMonth = 28;
            int monthsInYear = 12;

            int dayAfter5Days = day + 5;
            int monthAfter5Days = month;

            if (dayAfter5Days > daysInMonth)
            {
                dayAfter5Days -= daysInMonth;
                monthAfter5Days++;
            }
            if (monthAfter5Days > monthsInYear)
                monthAfter5Days -= monthsInYear;

            Console.WriteLine("{0}.{1:00}", dayAfter5Days, monthAfter5Days);
        }
    }
}
