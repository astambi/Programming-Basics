using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Book_Problem
{
    class _01_Book_Problem
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            //double pages = double.Parse(Console.ReadLine());
            int nonReadingDaysM = int.Parse(Console.ReadLine());
            int pagesReadD = int.Parse(Console.ReadLine());
            // month = 30 days, year = 12 months
            int readingDaysM = 30 - nonReadingDaysM;

            if (readingDaysM != 0 && pagesReadD != 0)
            {
                // NB!!! double / int or double pages
                double readingDaysNeeded = 1.00 * pages / pagesReadD; 
                double totalMonthsNeeded = Math.Ceiling(readingDaysNeeded / readingDaysM); //roundup
                
                double yearsNeeded = Math.Truncate(totalMonthsNeeded / 12);
                double monthsNeeded = totalMonthsNeeded % 12;
                //double monthsNeeded = totalMonthsNeeded - yearsNeeded * 12;

                Console.WriteLine("{0} years {1} months", yearsNeeded, monthsNeeded);
            }
            else
                Console.WriteLine("never");
        }
    }
}
