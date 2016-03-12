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

            string result = DayOfWeek(day);
            Console.WriteLine(result);
        }

        static string DayOfWeek(int day)
        {
            string weekday;
            switch (day)
            {
                case 1: weekday = "Monday"; break;
                case 2: weekday = "Tuesday"; break;
                case 3: weekday = "Wednesday"; break;
                case 4: weekday = "Thursday"; break;
                case 5: weekday = "Friday"; break;
                case 6: weekday = "Saturday"; break;
                case 7: weekday = "Sunday"; break;
                default: weekday = "Error!"; break;
            }
            return weekday;
        }
    }
}
