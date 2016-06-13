using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dream_Item
{
    class Dream_Item
    {
        static void Main(string[] args)
        {
            string[] month = { "Jan", "Feb", "March", "Apr", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int holidaysInMonth = 10;
            decimal bonus = 1.1m;
            decimal bonusThreshold = 700m;
            int workingDays = 0;

            string input = Console.ReadLine();
            // input format "Month\Money per hour\Hours per day\Price of the item"

            string[] inputDetails = input.Split('\\');
            // splits input into array[4] { month, moneyPerHour, hoursPerDay, priceItem }

            // working days
            for (int i = 0; i < 12; i++)
            {
                if (inputDetails[0] == month[i])
                {
                    workingDays = daysInMonth[i] - holidaysInMonth;
                    break;
                }
            }
            // money earned
            decimal moneyPerHour = decimal.Parse(inputDetails[1]);
            int hoursPerDay = int.Parse(inputDetails[2]);
            decimal priceItem = decimal.Parse(inputDetails[3]);

            decimal moneyEarned = workingDays * hoursPerDay * moneyPerHour;
            // bonus for money earned above bonus threshold
            if (moneyEarned > bonusThreshold)       
                moneyEarned *= bonus;

            bool enoughMoney = moneyEarned >= priceItem;
            decimal moneyDiff = Math.Abs(moneyEarned - priceItem);

            if (enoughMoney)
                Console.WriteLine("Money left = {0:0.00} leva.",moneyDiff);
            else
                Console.WriteLine("Not enough money. {0:0.00} leva needed.", moneyDiff);
        }
    }
}
