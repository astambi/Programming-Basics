using System;

namespace Master_Herbalist
{
    class Master_Herbalist
    {
        static void Main(string[] args)
        {
            decimal dailyExpenses = decimal.Parse(Console.ReadLine());
            string inputOver = "Season Over";
            string input = "";
            decimal earnings = 0;
            decimal averageEarnings = 0;
            int days = 0;

            while ((input = Console.ReadLine()) != inputOver)
            {
                days++;
                string[] inputDetails = input.Split(' ');   // "hours path price"
                int hours = int.Parse(inputDetails[0]);
                string path = inputDetails[1];
                int herbPrice = int.Parse(inputDetails[2]);

                int herbsFound = 0;
                for (int i = 0; i < hours; i++)
                {
                    if (path[i % path.Length] == 'H')       // loop shorter paths to match hours
                        herbsFound++; 
                }
                earnings += herbPrice * herbsFound;
            }
            if (days > 0)
                averageEarnings = earnings / days;

            if (averageEarnings >= dailyExpenses)
                Console.WriteLine("Times are good. Extra money per day: {0:f2}.", averageEarnings - dailyExpenses);
            else
                Console.WriteLine("We are in the red. Money needed: {0:0}.", dailyExpenses * days - earnings);
        }
    }
}