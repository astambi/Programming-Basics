using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Melons_and_Watermelons
{
    class Melons_and_Watermelons
    {
        static void Main(string[] args)
        {
            int startingDay = int.Parse(Console.ReadLine());
            int sequentialDays = int.Parse(Console.ReadLine());
            int[] watermelons = { 1, 0, 1, 2, 2, 1, 0 }; // eaten per day
            int[] melons =      { 0, 2, 1, 0, 2, 2, 0 };
            // days = 			{1,2,3,4,5,6,7} 
            int indexDay = startingDay - 1;
            int amountMelons = 0;
            int amountWatermelons = 0;

            for (int day = indexDay; day < indexDay + sequentialDays; day++)
            {
                amountMelons += melons[day % 7];
                amountWatermelons += watermelons[day % 7];
            }
            string moreEaten = "melons";
            if (amountMelons < amountWatermelons)
                moreEaten = "watermelons";
            if (amountMelons == amountWatermelons)
                Console.WriteLine("Equal amount: {0}", amountMelons);
            else
                Console.WriteLine("{0} more {1}", Math.Abs(amountMelons - amountWatermelons), moreEaten);
        }
    }
}
