using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Traveller_Bob
{
    class Traveller_Bob
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine().ToLower(); // leap, normal
            int contractMonths = int.Parse(Console.ReadLine());
            int familyMonths = int.Parse(Console.ReadLine());
            int normalMonths = 12 - contractMonths - familyMonths;
            int weeksInMonth = 4; 
            int travelsPerWeekContractMonth = 3;
            int travelsPerWeekFamilyMonth = 2;
            int travelingWeeksFamilyMonth = 2;
            double travelsNormalMonth = 3.00 / 5.00; // 3/5 travels in contract month
            double leapYearIncrease = 1.05; 

            double travels = 0;
            travels += travelsPerWeekContractMonth * weeksInMonth * contractMonths;
            travels += travelsPerWeekFamilyMonth * travelingWeeksFamilyMonth * familyMonths;
            travels += (travelsPerWeekContractMonth * weeksInMonth) * travelsNormalMonth * normalMonths;

            if (yearType == "leap")
                travels *= leapYearIncrease;
            Console.WriteLine("{0}", Math.Floor(travels));
        }
    }
}
