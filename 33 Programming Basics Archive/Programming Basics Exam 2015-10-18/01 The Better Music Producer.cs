using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_The_Better_Music_Producer
{
    class _01_The_Better_Music_Producer
    {
        static void Main(string[] args)
        {
            int[] albums = { 0, 0, 0 };                     // {EUR, NAmerica, SAmerica}
            decimal[] albumPrice = { 0m, 0m, 0m };          // {EUR, NAmerica, SAmerica}
            decimal[] fx = { 1.94m, 1.72m, 1m / 332.74m };  // {EUR, NAmerica, SAmerica}

            for (int i = 0; i < 3; i++)
            {
                albums[i] = int.Parse(Console.ReadLine());
                albumPrice[i] = decimal.Parse(Console.ReadLine());
            }
            int concerts = int.Parse(Console.ReadLine());
            decimal profitConcertEUR = decimal.Parse(Console.ReadLine());

            decimal profitAlbums = 0;
            for (int i = 0; i < 3; i++)
                profitAlbums += albums[i] * albumPrice[i] * fx[i];
            profitAlbums *= (1m - 0.35m) * (1m - 0.20m);   // net profit after producer's commission & taxes

            decimal profitConcerts = concerts * profitConcertEUR * fx[0];
            if (profitConcerts > 100000m)
                profitConcerts *= (1m - 0.15m);            // net profit after producer's commission

            bool albumsMoreProfitable = profitAlbums > profitConcerts;

            if (albumsMoreProfitable)
                Console.WriteLine("Let's record some songs! They'll bring us {0:0.00}lv.", profitAlbums);
            else
                Console.WriteLine("On the road again! We'll see the world and earn {0:0.00}lv.", profitConcerts);
        }
    }
}
