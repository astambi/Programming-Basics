using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week_3
{
    class Day_of_Week_3
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string dayOfWeek = GetDayOfWeek(day);
            Console.WriteLine(dayOfWeek);
        }

        static string GetDayOfWeek(int day)
        {
            string dayOfWeek;
            switch (day)
            {
                case 1: dayOfWeek = "Monday"; break;
                case 2: dayOfWeek = "Tuesday"; break;
                case 3: dayOfWeek = "Wednesday"; break;
                case 4: dayOfWeek = "Thursday"; break;
                case 5: dayOfWeek = "Friday"; break;
                case 6: dayOfWeek = "Saturday"; break;
                case 7: dayOfWeek = "Sunday"; break;
                default: dayOfWeek = "Error!"; break;
            }
            return dayOfWeek;
        }
    }
}
