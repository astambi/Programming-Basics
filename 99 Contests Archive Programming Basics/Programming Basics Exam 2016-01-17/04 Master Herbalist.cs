using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Master_Herbalist_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyExpenses = int.Parse(Console.ReadLine());
            int days = 0;
            string dailyInput = "";
            string endOfInput = "Season Over";
            double totalMoneyMade = 0;

            while ((dailyInput = Console.ReadLine()) != endOfInput)
            {
                string[] inputDetails = dailyInput.Split(' ');  //splits input into array {hours, path, price}
                int hours = int.Parse(inputDetails[0]);         //parses input 
                string path = inputDetails[1];
                int herbPrice = int.Parse(inputDetails[2]);
                int numHerbs = 0;

                while (path.Length < hours)                     //loops path if path lenght < hours spends in the mountains
                    path += inputDetails[1];
                for (int i = 0; i < hours; i++)
                {
                    if (path[i] == 'H')                         //counts number of H chars in the array (herbs/day)
                        ++numHerbs;
                }
                totalMoneyMade += herbPrice * numHerbs;
                ++days;
            }
            double averageEarnings = totalMoneyMade / days;

            if (averageEarnings >= dailyExpenses)
                Console.WriteLine("Times are good. Extra money per day: {0:0.00}.", averageEarnings - dailyExpenses);
            else
                Console.WriteLine("We are in the red. Money needed: {0:0}.", dailyExpenses * days - totalMoneyMade);
        }
    }
}
