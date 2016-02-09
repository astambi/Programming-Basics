using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Master_Herbalist
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyExpenses = int.Parse(Console.ReadLine());

            string path = "";
            int days = 0;
            int hours = 0;
            int herbPrice = 0;
            int numHerbs = 0;
            double totalMoneyMade = 0;
            string dailyInput = "";
            string endOfInput = "Season Over";

            while ((dailyInput = Console.ReadLine()) != endOfInput)
            {
                string[] inputDetails = dailyInput.Split(' ');  //splits input into array {hours, path, price}
                hours = int.Parse(inputDetails[0]);             //parses input 
                path = inputDetails[1];
                herbPrice = int.Parse(inputDetails[2]);
                numHerbs = 0;
                while (path.Length < hours)                     //loops path if path lenght < hours spends in the mountains
                    path += inputDetails[1];
                char[] pathLetters = path.ToCharArray();        //converts path from string to char array
                for (int i = 0; i < hours; i++)
                {
                    if (pathLetters[i] == 'H')                  //counts number of H chars in the array (herbs/day)
                        numHerbs += 1;           
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