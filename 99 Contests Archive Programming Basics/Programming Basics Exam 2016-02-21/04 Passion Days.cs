using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Passion_Days
{
    class _04_Passion_Days
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string inputStart = "mall.Enter";
            string inputEnd = "mall.Exit";
            string[] details = new string[20];
            int inputCount = -1;
            int purchases = 0;
            string input = "";
            string lineInput = "";

            while ((input = Console.ReadLine()) != inputStart) { }

            while ((input = Console.ReadLine()) != inputEnd)
            {
                ++inputCount;
                details[inputCount] = input;
            }

            for (int i = 0; i <= inputCount; i++) // [0]
            {
                lineInput = details[i];

                for (int j = 0; j < lineInput.Length; j++)
                {
                    bool uppercase = (int)lineInput[j] >= 65 && (int)lineInput[j] <= 90;
                    bool lowercase = (int)lineInput[j] >= 97 && (int)lineInput[j] <= 122;
                    bool procent = (int)lineInput[j] == 37;
                    bool astersk = (int)lineInput[j] == 42;

                    if (uppercase && money >= (int)lineInput[j] * 0.5m) //uppercase & enough money
                    {
                        money -= (int)lineInput[j] * 0.5m;
                        ++purchases;
                    }
                    else if (lowercase && money >= (int)lineInput[j] * 0.3m) //lowercase & enough money
                    {
                        money -= (int)lineInput[j] * 0.3m;
                        ++purchases;
                    }
                    else if (procent && money > 0) // %
                    {
                        money /= 2m;
                        ++purchases;
                    }
                    else if (astersk) // *
                        money += 10m;
                    else if (money >= (int)lineInput[j]) //any other char & enough money
                    {
                        money -= (int)lineInput[j];
                        ++purchases;
                    }
                }
            }
            if (purchases == 0)
                Console.WriteLine("No purchases. Money left: {0:0.00} lv.", money);
            else
                Console.WriteLine("{0} purchases. Money left: {1:0.00} lv.", purchases, money);
        }
    }
}
