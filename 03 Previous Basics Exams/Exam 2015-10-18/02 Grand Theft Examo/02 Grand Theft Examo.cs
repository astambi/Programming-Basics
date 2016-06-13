using System;

class Grand_Theft_Examo
{
    static void Main(string[] args)
    {
        int attempts = int.Parse(Console.ReadLine());
        double beers = 0;
        double thievesSlapped = 0;
        double thievesEscaped = 0;

        for (int i = 0; i < attempts; i++)
        {
            int thieveArrivals = int.Parse(Console.ReadLine());
            beers += double.Parse(Console.ReadLine());
            thievesSlapped += Math.Min(5, thieveArrivals); // max 5 thieves per arrival
            thievesEscaped += thieveArrivals - Math.Min(5, thieveArrivals);
        }
        Console.WriteLine("{0} thieves slapped.", thievesSlapped);
        Console.WriteLine("{0} thieves escaped.", thievesEscaped);
        Console.WriteLine("{0} packs, {1} bottles.", Math.Truncate(beers / 6), beers % 6);
    }
}
