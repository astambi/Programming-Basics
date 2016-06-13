using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Budget
{
    class Budget
    {
        static void Main(string[] args)
        {
            decimal monthlyBudget = decimal.Parse(Console.ReadLine());
            int weekdaysOut = int.Parse(Console.ReadLine());
            int weekendsHomeTown = int.Parse(Console.ReadLine());
            
            int weekdaysHome = 30 - 2 * 4 - weekdaysOut; // month = 30 days, 4 weekends
            int weekendsHome = 4 - weekendsHomeTown;
            decimal expensesWeekday = 10m;
            decimal expensesGoingOutDay = 0.03m;    // of total budget
            decimal expensesWeekends = 20m;         // expensesHomeTown = 0;
            decimal monthlyRent = 150m;
            decimal monthlyExpenses = (30 - 2 * 4) * expensesWeekday
                                        + weekdaysOut * Math.Truncate(expensesGoingOutDay * monthlyBudget)
                                        + 2 * weekendsHome * expensesWeekends
                                        + monthlyRent;
            decimal budgetDiff = monthlyBudget - monthlyExpenses;

            if (budgetDiff == 0)
                Console.WriteLine("Exact Budget.");
            else if (budgetDiff > 0)
                Console.WriteLine("Yes, leftover {0}.", budgetDiff);
            else
                Console.WriteLine("No, not enough {0}.", -budgetDiff);
        }
    }
}
