using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Beers
{
    class Beers
    {
        static void Main(string[] args)
        {
            string input = "";
            string endOfInput = "end";
            int totalAmountBeer = 0;

            while ( (input = Console.ReadLine().ToLower()) != endOfInput )
            {
                // splits input into array[2] { amount, beerType)
                string[] inputDetails = input.Split(' ');

                int amount = int.Parse(inputDetails[0]);
                string type = inputDetails[1];

                // beerTypes { "stacks", "beers"} = {20, 1} beers
                if (type == "stacks")
                    totalAmountBeer += amount * 20;
                else if (type == "beers")
                    totalAmountBeer += amount; 
            }
            int amountStacks = totalAmountBeer / 20;
            int amountBeers = totalAmountBeer % 20;

            Console.WriteLine("{0} stacks + {1} beers",amountStacks,amountBeers);
        }
    }
}
