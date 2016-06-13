using System;

namespace Cake_Tycoon
{
    class Cake_Tycoon
    {
        static void Main(string[] args)
        {
            ulong cakesPlanned = ulong.Parse(Console.ReadLine()); 
            double flourPerCake = double.Parse(Console.ReadLine());
            uint flourQuantity = uint.Parse(Console.ReadLine());    // flourPrice = 0
            uint truffleQuantity = uint.Parse(Console.ReadLine()); 
            uint trufflePrice = uint.Parse(Console.ReadLine());

            double cakesProduced = Math.Min(cakesPlanned, Math.Truncate(flourQuantity / flourPerCake)); 
            double cakePrice = truffleQuantity / cakesProduced * trufflePrice * 1.25;
            double flourDiff = cakesPlanned * flourPerCake - flourQuantity;
            if (cakesProduced < cakesPlanned)
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour", cakesProduced, flourDiff);
            else
                Console.WriteLine("All products available, price of a cake: {0:f2}", cakePrice);
        }
    }
}