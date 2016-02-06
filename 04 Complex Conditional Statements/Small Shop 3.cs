using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string location = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            string[] products = new string[]                { "coffee", "water", "beer", "sweets", "peanuts" };
            double[] productPricesSofia = new double[]      { 0.50, 0.80, 1.20, 1.45, 1.60 };
            double[] productPricesPlovdiv = new double[]    { 0.40, 0.70, 1.15, 1.30, 1.50 };
            double[] productPricesVarna = new double[]      { 0.45, 0.70, 1.10, 1.35, 1.55 };

            for (int i = 0; i < 5; i++)
            {
                if (product == products[i])
                {
                    if (location == "sofia")
                        price = productPricesSofia[i];
                    else if (location == "plovdiv")
                        price = productPricesPlovdiv[i];
                    else if (location == "varna")
                        price = productPricesVarna[i];
                }
            }
            Console.WriteLine(quantity * price);
        }
    }
}