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
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", null);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}