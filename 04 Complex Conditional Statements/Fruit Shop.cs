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
            string fruit = Console.ReadLine().ToLower();
            string weekday = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (weekday == "saturday" || weekday == "sunday")
            {
                if (fruit == "banana")
                    price = 2.70;
                else if (fruit == "apple")
                    price = 1.25;
                else if (fruit == "orange")
                    price = 0.90;
                else if (fruit == "grapefruit")
                    price = 1.60;
                else if (fruit == "kiwi")
                    price = 3.00;
                else if (fruit == "pineapple")
                    price = 5.60;
                else if (fruit == "grapes")
                    price = 4.20;
            }
            else if (weekday == "monday" || weekday == "tuesday" || weekday == "wednesday" || weekday == "thursday" || weekday == "friday")
            {
                if (fruit == "banana")
                    price = 2.50;
                else if (fruit == "apple")
                    price = 1.20;
                else if (fruit == "orange")
                    price = 0.85;
                else if (fruit == "grapefruit")
                    price = 1.45;
                else if (fruit == "kiwi")
                    price = 2.70;
                else if (fruit == "pineapple")
                    price = 5.50;
                else if (fruit == "grapes")
                    price = 3.85;
            }

            if (price > 0)
                Console.WriteLine("{0:f2}", price * quantity);
            else
                Console.WriteLine("error");
        }
    }
}