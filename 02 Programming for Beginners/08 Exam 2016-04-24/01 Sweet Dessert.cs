using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Dessert
{
    class Sweet_Dessert
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());

            decimal[] prices = new decimal[3]; // bananas, eggs, berries [0, 1000]
            for (int i = 0; i < 3; i++)
                prices[i] = decimal.Parse(Console.ReadLine());

            int quantityDesserts6 = (int)Math.Ceiling(guests / 6.00);
            decimal priceOfProducts = quantityDesserts6 * 
                                    (2 * prices[0] + 4 * prices[1] + 0.2m * prices[2]);

            if (priceOfProducts <= money)
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", priceOfProducts);
            else
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", priceOfProducts - money);
        }
    }
}
