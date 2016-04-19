using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
    class Day_of_Week
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (dayOfWeek >= 1 && dayOfWeek <= 7)
                Console.WriteLine(weekdays[dayOfWeek - 1]);
            else
                Console.WriteLine("invalid day");
        }
    }
}
