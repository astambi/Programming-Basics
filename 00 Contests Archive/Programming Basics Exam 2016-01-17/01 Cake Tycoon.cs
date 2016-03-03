using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cake_Tycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakesPlanned = int.Parse(Console.ReadLine()); 
            double flourPerCake = double.Parse(Console.ReadLine()); //kg
            int flourAvailable = int.Parse(Console.ReadLine());     //kg, cost of flour = 0
            int numTruffles = int.Parse(Console.ReadLine()); 
            int priceTruffle = int.Parse(Console.ReadLine()); 

            double cakesProduced = Math.Min(cakesPlanned, Math.Truncate(flourAvailable / flourPerCake)); // max cakesProduced <= cakesPlanned
            double priceCake = numTruffles / cakesProduced * priceTruffle * 1.25;   // NB division first!!! cost trufles, 25% profit
            double flourShortage = cakesPlanned * flourPerCake - flourAvailable;    //kg
            var shortage = cakesProduced < cakesPlanned;

            if (shortage)
                Console.WriteLine("Can make only {0} cakes, need {1:0.00} kg more flour", cakesProduced, flourShortage);
            else
                Console.WriteLine("All products available, price of a cake: {0:0.00}", priceCake);
        }
    }
}