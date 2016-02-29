using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hungry_Garfield
{
    class _01_Hungry_Garfield
    {
        static void Main(string[] args)
        {
            decimal moneyUSD = decimal.Parse(Console.ReadLine());
            decimal fxUSD = decimal.Parse(Console.ReadLine());
            decimal[] priceUSD = new decimal[] { 0m, 0m, 0m }; // {pizza, lasagna, sandwich }
            decimal[] quantity = new decimal[] { 0m, 0m, 0m }; // {pizza, lasagna, sandwich }
            decimal foodCostUSD = 0m;

            for (int i = 0; i < 3; i++)
                priceUSD[i] = decimal.Parse(Console.ReadLine()) / fxUSD;
            for (int i = 0; i < 3; i++)
            {
                quantity[i] = decimal.Parse(Console.ReadLine());
                foodCostUSD += priceUSD[i] * quantity[i];
            }
            bool enoughMoney = moneyUSD >= foodCostUSD;
            decimal moneyDiff = Math.Abs(moneyUSD - foodCostUSD);

            if (enoughMoney)
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:0.00}.", moneyDiff);
            else
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:0.00}.", moneyDiff);
        }
    }
}
