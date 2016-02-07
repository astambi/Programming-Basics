using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Beer_Stock_2
{
    class Program
    {
        static void Main(string[] args)
        {
            long beersReserved = int.Parse(Console.ReadLine());             // NB! long instead of int!
            string[] beerType = new string[] { "cases", "sixpacks", "beers" };
            int[] beerTypeAmount = new int[] { 24, 6, 1 };
            long[] beerShipment = new long[] { 0, 0, 0 };
            long[] beerCalc = new long[] { 0, 0, 0 };
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

            long beersShipped = 0;
            for (int i = 0; i < 3; i++)
                beersShipped += beerShipment[i] * beerTypeAmount[i];        //calculates total beers shipped
            beersShipped -= beersShipped / 100;                             //every 100th beer shipped is broken, therefore discarded

            long diffBeers = Math.Abs(beersReserved - beersShipped);        //beers needed or beers left
            for (int i = 0; i < 3; i++)
            {
                beerCalc[i] = diffBeers / beerTypeAmount[i];                //converts beers needed/left into beerTypes & quantities
                diffBeers = diffBeers % beerTypeAmount[i];
            }

            if (beersShipped < beersReserved)                               // beer shortage
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", beerCalc[0], beerCalc[1], beerCalc[2]);
            else               
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", beerCalc[0], beerCalc[1], beerCalc[2]);
        }
    }
}