using System;

class Impress_the_girlfriend
{
    static void Main(string[] args)
    {
        decimal[] FX = new decimal[] { 3.5m / 100, 1.5m, 1.95m, 1m, 1m };  // RUB,USD,EUR,BGNb,BGNm
        decimal[] priceBGN = new decimal[5];
        decimal maxPrice = 0;
        for (int i = 0; i < 5; ++i)
        {
            priceBGN[i] = long.Parse(Console.ReadLine()) * FX[i]; 
            if (i == 3)
                priceBGN[i] /= 2;       // special price for 2 games
            if (priceBGN[i] > maxPrice)
                maxPrice = priceBGN[i];
        }
        Console.WriteLine("{0:f2}", Math.Ceiling(maxPrice));
    }
}