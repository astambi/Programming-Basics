using System;

namespace Beer_Stock
{
    class Beer_Stock
    {
        static void Main(string[] args)
        {
            long beersOrdered = long.Parse(Console.ReadLine());
            int[] packagingQuantity = new int[] { 24, 6, 1 };   // cases, sixpacks, beers
            long[] beersDiff = new long[3];                     // cases, sixpacks, beers
            long beersShipped = 0;
            string inputOver = "Exam Over";
            string input = "";

            while ((input = Console.ReadLine()) != inputOver)
            {
                string[] shipmentDetails = input.Split(' '); 
                long shipmentQuantity = long.Parse(shipmentDetails[0]);
                string shipmentProduct = shipmentDetails[1];
                switch (shipmentProduct)
                {
                    case "cases":    beersShipped += shipmentQuantity * 24; break;
                    case "sixpacks": beersShipped += shipmentQuantity * 6; break;
                    case "beers":    beersShipped += shipmentQuantity; break;
                }
            }
            beersShipped -= beersShipped / 100;     // every 100th beer shipped is broken & discarded
            beersDiff[2] = Math.Abs(beersOrdered - beersShipped);
            for (int i = 0; i < packagingQuantity.Length - 1; i++)
            {
                beersDiff[i] = beersDiff[2] / packagingQuantity[i];
                beersDiff[2] %= packagingQuantity[i];
            }
            if (beersShipped < beersOrdered)
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", 
                    beersDiff[0], beersDiff[1], beersDiff[2]);
            else
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", 
                    beersDiff[0], beersDiff[1], beersDiff[2]);
        }
    }
}