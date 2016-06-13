using System;

namespace Passion_Days
{
    class Passion_Days
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string inputStart = "mall.Enter";
            string inputEnd = "mall.Exit";
            string input = "";
            int purchases = 0;
            while ((input = Console.ReadLine()) != inputStart) { }
            while ((input = Console.ReadLine()) != inputEnd)
            {
                foreach (char character in input)
                {
                    if (character == '*')                                           // no purchases, extra cash
                        money += 10m;
                    else if (char.IsUpper(character) && money >= character * 0.5m)  // uppercase & enough money
                    {
                        purchases++;
                        money -= character * 0.5m; 
                    }
                    else if (char.IsLower(character) && money >= character * 0.3m)  // lowercase & enough money
                    {
                        purchases++;
                        money -= character * 0.3m; 
                    }
                    else if (character == '%' && money > 0)                         // % & enough money
                    {
                        purchases++;
                        money /= 2m;
                    }
                    else if (money >= character)                                    // other char & enough money
                    {
                        purchases++;
                        money -= character;
                    }
                }      
            }            
            if (purchases == 0)
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", money);
            else
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchases, money);
        }
    }
}