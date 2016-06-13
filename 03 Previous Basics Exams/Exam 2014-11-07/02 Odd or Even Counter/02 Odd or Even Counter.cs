using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odd_or_Even_Counter
{
    class Odd_or_Even_Counter
    {
        static void Main(string[] args)
        {
            int sets = int.Parse(Console.ReadLine());   // [1,10]
            int numbersInSet = int.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine().ToLower();
            string[] ordinalNumbers = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth" };
            int maxCountSet = 0;
            int winningSet = 0;

            int remainder = 0;  // even number
            if (oddOrEven == "odd")
                remainder = 1;
            for (int i = 0; i < sets; i++)
            {
                int count = 0;
                for (int j = 0; j < numbersInSet; j++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number % 2 == remainder)
                        count++;
                }
                if (maxCountSet < count)
                {
                    maxCountSet = count;
                    winningSet = i;
                }
            }
            if (maxCountSet > 0)
                Console.WriteLine("{0} set has the most {1} numbers: {2}", ordinalNumbers[winningSet], oddOrEven, maxCountSet);
            else
                Console.WriteLine("No");
        }
    }
}
