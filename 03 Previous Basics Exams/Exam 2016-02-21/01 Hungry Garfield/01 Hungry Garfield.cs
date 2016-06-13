using System;

class Hungry_Garfield
{
    static void Main()
    {
        decimal moneyUSD = decimal.Parse(Console.ReadLine());
        decimal fxUSD = decimal.Parse(Console.ReadLine());
        decimal[] pricesUSD = new decimal[] { 0m, 0m, 0m };             // pizza, lasagna, sandwich
        decimal foodCostUSD = 0m;
        for (int i = 0; i < 3; i++)
            pricesUSD[i] = decimal.Parse(Console.ReadLine()) / fxUSD;   // pizza, lasagna, sandwich
        for (int i = 0; i < 3; i++)
        {
            decimal quantity = decimal.Parse(Console.ReadLine());       // pizza, lasagna, sandwich
            foodCostUSD += quantity * pricesUSD[i];
        }
        decimal moneyDiff = Math.Abs(moneyUSD - foodCostUSD);
        bool enoughMoney = moneyUSD >= foodCostUSD;
        if (enoughMoney)
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:0.00}.", moneyDiff);
        else
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:0.00}.", moneyDiff);
    }
}