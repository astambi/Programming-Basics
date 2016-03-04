using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Torrent_Pirate
{
    class Torrent_Pirate
    {
        static void Main(string[] args)
        {
            int megabytesToDload = int.Parse(Console.ReadLine());
            decimal priceTicket = decimal.Parse(Console.ReadLine());
            decimal moneySpentH = decimal.Parse(Console.ReadLine());
            int megabytesMovie = 1500;
            int speedWiFi = 2; // MB/s
            decimal priceToPay = 0;
            string destination = "mall";

            decimal dloadTimeH = 1m * megabytesToDload / speedWiFi / 3600m;   // dload time mall, hours
            decimal shoppingExpensesMall = dloadTimeH * moneySpentH;

            decimal moviesDloaded = 1m * megabytesToDload / megabytesMovie;
            decimal cinemaExpenses = moviesDloaded * priceTicket; 

            bool cinemaIsCheaper = cinemaExpenses < shoppingExpensesMall;
            if (cinemaIsCheaper)
            {
                destination = "cinema";
                priceToPay = cinemaExpenses;
            }
            else
                priceToPay = shoppingExpensesMall;

            Console.WriteLine("{0} -> {1:0.00}lv",destination, priceToPay);
        }
    }
}
