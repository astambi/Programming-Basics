using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_On_Time_for_the_Exam
{
    class On_Time_for_the_Exam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());           // [0,23]
            int examMinute = int.Parse(Console.ReadLine());         // [0,59]
            int arrivingHour = int.Parse(Console.ReadLine());       // [0,23]
            int arrivingMinute = int.Parse(Console.ReadLine());     // [0,59]

            int examTimeInMinutes = examHour * 60 + examMinute;
            int arrivingTimeInMinutes = arrivingHour * 60 + arrivingMinute;

            int arrivingDiffInMinutes = examTimeInMinutes - arrivingTimeInMinutes;      // early (+), late (-)

            bool late = arrivingTimeInMinutes > examTimeInMinutes;
            bool onTime = arrivingDiffInMinutes >= 0 && arrivingDiffInMinutes <= 30;    // [0',30']
            bool early = arrivingDiffInMinutes > 30;                                    // > 30'
            bool minDiff = Math.Abs(arrivingDiffInMinutes) >= 1;                        // > 1'

            if (late)
                Console.WriteLine("Late");
            else if (onTime)
                Console.WriteLine("On time");
            else if (early)
                Console.WriteLine("Early");

            if (minDiff)
            {
                string status = "after";
                if (arrivingDiffInMinutes > 0)                                          // arriving before exam time
                    status = "before";
                
                int diffHours = Math.Abs(arrivingDiffInMinutes) / 60;
                int diffMinutes = Math.Abs(arrivingDiffInMinutes) % 60;

                if (diffHours > 0)
                    Console.WriteLine("{0}:{1:00} hours {2} the start", diffHours, diffMinutes, status);
                else
                    Console.WriteLine("{0} minutes {1} the start", diffMinutes, status);
            }            
        }
    }
}
