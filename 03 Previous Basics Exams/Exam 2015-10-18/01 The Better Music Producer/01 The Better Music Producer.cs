using System;

class The_Better_Music_Producer
{
    static void Main()
    {
        decimal[] fx = { 1.94m, 1.72m, 1m / 332.74m };              // {EUR, NAmerica, SAmerica}
        decimal profitAlbums = 0;
        for (int i = 0; i < 3; i++)
        {
            int albums = int.Parse(Console.ReadLine());             // {EUR, NAmerica, SAmerica}
            decimal albumPrice = decimal.Parse(Console.ReadLine()); // {EUR, NAmerica, SAmerica}
            profitAlbums += albums * albumPrice * fx[i];
        }
        profitAlbums *= (1m - 0.35m) * (1m - 0.20m);    // profit after commission & taxes

        int concerts = int.Parse(Console.ReadLine());
        decimal profitPerConcertEUR = decimal.Parse(Console.ReadLine());           
        decimal profitConcerts = concerts * profitPerConcertEUR * fx[0];
        if (profitConcerts > 100000m)
            profitConcerts *= (1m - 0.15m);             // profit after commission

        if (profitAlbums > profitConcerts)
            Console.WriteLine("Let's record some songs! They'll bring us {0:f2}lv.", profitAlbums);
        else
            Console.WriteLine("On the road again! We'll see the world and earn {0:f2}lv.", profitConcerts);
    }
}
