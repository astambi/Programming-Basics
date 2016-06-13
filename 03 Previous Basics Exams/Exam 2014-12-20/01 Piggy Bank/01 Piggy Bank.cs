using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Piggy_Bank
{
    class Piggy_Bank
    {
        static void Main(string[] args)
        {
            decimal priceTank = decimal.Parse(Console.ReadLine());
            int partyDaysInMonth = int.Parse(Console.ReadLine());
            decimal savingPerDay = 2;
            decimal partyExpences = 5; 
            int daysInMonth = 30;

            decimal savingsInMonth = (daysInMonth - partyDaysInMonth) * savingPerDay - partyDaysInMonth * partyExpences;
            if (savingsInMonth > 0)
            {
                decimal totalMonthsNeeded = Math.Ceiling(priceTank / savingsInMonth);
                decimal yearsNeeded = Math.Truncate(totalMonthsNeeded / 12);
                decimal monthsNeeded = totalMonthsNeeded % 12;
                Console.WriteLine("{0} years, {1} months", yearsNeeded, monthsNeeded);
            }
            else
                Console.WriteLine("never");
        }
    }
}
