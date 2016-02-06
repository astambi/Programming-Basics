using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string weekday = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            var weekend =       weekday == "sunday" || weekday == "saturday";
            var businessday =   weekday == "monday" || weekday == "tuesday" || weekday == "wednesday" || weekday == "thursday" || weekday == "friday";
            
            if (weekend)
            {
                if (product == "banana")
                    price = 2.70;
                else if (product == "apple")
                    price = 1.25;
                else if (product == "orange")
                    price = 0.90;
                else if (product == "grapefruit")
                    price = 1.60;
                else if (product == "kiwi")
                    price = 3.00;
                else if (product == "pineapple")
                    price = 5.60;
                else if (product == "grapes")
                    price = 4.20;
            }
            else if (businessday)
            {
                if (product == "banana")
                    price = 2.50;
                else if (product == "apple")
                    price = 1.20;
                else if (product == "orange")
                    price = 0.85;
                else if (product == "grapefruit")
                    price = 1.45;
                else if (product == "kiwi")
                    price = 2.70;
                else if (product == "pineapple")
                    price = 5.50;
                else if (product == "grapes")
                    price = 3.85;
            }

            if (price > 0)
                Console.WriteLine("{0:f2}", price * quantity); //format 0.00 or f2
            else
                Console.WriteLine("error"); //unknown product or weekday
        }
    }
}