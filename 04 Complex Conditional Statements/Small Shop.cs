﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string location = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (location == "sofia")
            {
                if (product == "coffee")
                    price = 0.50;
                else if (product == "water")
                    price = 0.80;
                else if (product == "beer")
                    price = 1.20;
                else if (product == "sweets")
                    price = 1.45;
                else if (product == "peanuts")
                    price = 1.60;
            }
            else if (location == "plovdiv")
            {
                if (product == "coffee")
                    price = 0.40;
                else if (product == "water")
                    price = 0.70;
                else if (product == "beer")
                    price = 1.15;
                else if (product == "sweets")
                    price = 1.30;
                else if (product == "peanuts")
                    price = 1.50;
            }
            else if (location == "varna")
            {
                if (product == "coffee")
                    price = 0.45;
                else if (product == "water")
                    price = 0.70;
                else if (product == "beer")
                    price = 1.10;
                else if (product == "sweets")
                    price = 1.35;
                else if (product == "peanuts")
                    price = 1.55;
            }

            Console.WriteLine(quantity * price);
        }
    }
}