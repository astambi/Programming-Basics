using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace _01_Baba_Tinche_Airlines
{
    class Program
    {
        static void Main(string[] args)
        {
            // {First Class, Business Class, Economy Class} 
            int[] passengersFlying = { 0, 0, 0 }; 
            int[] frequentFlyers = { 0, 0, 0 };  
            int[] purchasingMeals = { 0, 0, 0 };  
            int[] passengersFullCapacity = { 12, 28, 50 }; 
            decimal[] ticketPrice = { 7000m, 3500m, 1000m };
            decimal frequentFlyerDiscount = 0.3m;       // 70% off ticket price
            decimal mealPrice = 0.005m;                 // 0.5% * ticket price
            decimal maxPossibleIncome = 0m;
            decimal actualIncome = 0m;

            for (int i = 0; i < 3; i++)
            {
                string input = Console.ReadLine();      // format "passengers frequentFlyers purchasingMeal"
                string[] splitInput = input.Split(' '); // splits input into array[3] 

                passengersFlying[i] = int.Parse(splitInput[0]);
                frequentFlyers[i] = int.Parse(splitInput[1]);
                purchasingMeals[i] = int.Parse(splitInput[2]);

                actualIncome += (passengersFlying[i] - frequentFlyers[i]) * ticketPrice[i] 
                              + frequentFlyers[i] * frequentFlyerDiscount * ticketPrice[i]
                              + purchasingMeals[i] * ticketPrice[i] * mealPrice;
            }
            for (int i = 0; i < 3; i++)
                maxPossibleIncome += passengersFullCapacity[i] * ticketPrice[i] * (1 + mealPrice);
            decimal incomeDiff = maxPossibleIncome - actualIncome;

            Console.WriteLine("{0:0}",Math.Floor(actualIncome));    // cast to an integer !!!
            Console.WriteLine("{0:0}",incomeDiff);
        }
    }
}
