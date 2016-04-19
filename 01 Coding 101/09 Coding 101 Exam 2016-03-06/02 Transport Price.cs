using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Transport_Price
{
    class Transport_Price
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string travellingTime = Console.ReadLine().ToLower(); // day, night

            decimal taxiStartingFee = 0.70m;
            decimal taxiPriceDay = 0.79m;
            decimal taxiPriceNight = 0.90m;

            decimal busPrice = 0.09m;           // min km bus = 20;
            decimal trainPrice = 0.06m;         // min km train = 100;

            decimal expensesTaxi = 0;
            decimal expensesBus = 0;
            decimal expensesTrain = 0;
            decimal minExpenses = 0;

            expensesTrain = km * trainPrice;
            expensesBus = km * busPrice;

            if (travellingTime == "day")
                expensesTaxi = taxiStartingFee + km * taxiPriceDay;
            else if (travellingTime == "night")
                expensesTaxi = taxiStartingFee + km * taxiPriceNight;

            if (km >= 100)      // travelling options: taxi, bus, train
                minExpenses = Math.Min(Math.Min(expensesTrain, expensesBus), expensesTaxi);
            else if (km >= 20)  // travelling options: taxi, bus
                minExpenses = Math.Min(expensesBus, expensesTaxi);
            else                // travelling options: taxi
                minExpenses = expensesTaxi;

            Console.WriteLine(minExpenses);
        }
    }
}
