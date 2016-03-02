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
            int d = int.Parse(Console.ReadLine()); // [1,31]
            int m = int.Parse(Console.ReadLine()); // [1,12]

            int monthsPerYear = 12;

            bool daysPerMonth30 = m == 4 || m == 6 || m == 9 || m == 11;
            bool daysPerMonth28 = m == 2;
            int daysPerMonth = 31;
            if (daysPerMonth30)
                daysPerMonth = 30;
            else if (daysPerMonth28)
                daysPerMonth = 28;

            int after5DaysD = d + 5;
            int after5DaysM = m;

            if (after5DaysD > daysPerMonth)
            {
                after5DaysD -= daysPerMonth;
                after5DaysM++;
            }
            if (after5DaysM > monthsPerYear)
                after5DaysM -= monthsPerYear;

            Console.WriteLine("{0}.{1:00}", after5DaysD, after5DaysM);
        }
    }
}
