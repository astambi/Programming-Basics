using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Beer_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            long beersReserved = int.Parse(Console.ReadLine());             // NB! long instead of int!

            string[] beerType = new string[] { "cases", "sixpacks", "beers" };
            int[] beerTypeAmount = new int[] { 24, 6, 1 };
            long[] beerShipment = new long[] { 0, 0, 0 };
            long[] beerNeeded = new long[]   { 0, 0, 0 };
            long[] beerLeft = new long[]     { 0, 0, 0 };
            long beersShipped = 0;
            
            string endOfShipment = "exam over";
            string shipmentInput = "";

            while ((shipmentInput = Console.ReadLine().ToLower()) != endOfShipment)
            {                                                               //logs shipments until shipment is over
                string[] shipmentDetails = shipmentInput.Split(' ');        //splits shipmentInput format "shipmentQuantity shipmentType" into array[shipmentQuantity, shipmentType]
                for (int i = 0; i < 3; i++)
                {
                    if (shipmentDetails[1] == beerType[i])                  //if shipmentType matches beerType, adds shipmentQuantity to the respective beerShipment amount
                        beerShipment[i] += long.Parse(shipmentDetails[0]);  //parses shipmentQuantity from string to int 
                }
            }
            
            for (int i = 0; i < 3; i++)
                beersShipped += beerShipment[i] * beerTypeAmount[i];        //calculates total beers shipped
            beersShipped -= beersShipped / 100;                             //every 100th beer shipped is broken, therefore discarded

            bool beerShortage = beersShipped < beersReserved;
            long diffBeers = Math.Abs(beersReserved - beersShipped);        //extra beers needed or extra beers left

            if (beerShortage)   //not enough beers
            {
                for (int i = 0; i < 3; i++)
                {
                    beerNeeded[i] = diffBeers / beerTypeAmount[i];          //converts extra beers into beerTypes & quantities
                    diffBeers = diffBeers % beerTypeAmount[i];
                }
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", beerNeeded[0], beerNeeded[1], beerNeeded[2]);
            }
            else                //just enough beers or some beers left
            {
                for (int i = 0; i < 3; i++)
                {
                    beerLeft[i] = diffBeers / beerTypeAmount[i];            //converts extra beers into beerTypes & quantities
                    diffBeers = diffBeers % beerTypeAmount[i];
                }
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", beerLeft[0], beerLeft[1], beerLeft[2]);
            }
        }
    }
}