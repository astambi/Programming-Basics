using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Gambling
{
    class _04_Gambling
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            string[] houseHand = Console.ReadLine().Split(' ');
            
            int[] cardValues = GetCardValues(houseHand);

            // calc hand strength and probability of drawing a winning hand
            int strengthHouseHand = cardValues.Sum();
            decimal winningProbability = CalcProbabilityWinning(cardValues);
            decimal expectedEarnings = cash * 2 * winningProbability;
            bool highProbability = winningProbability > 0.5m;

            // print result
            if (highProbability) Console.WriteLine("DRAW");
            else Console.WriteLine("FOLD");
            Console.WriteLine("{0:0.00}", expectedEarnings);
        }
        static int[] GetCardValues(string[] hand)
        {
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int[] handValues = new int[4];

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 13; j++)
                    if (hand[i] == cards[j])
                    {
                        handValues[i] = values[j];
                        break;
                    }
            return handValues;
        }
        static decimal CalcProbabilityWinning (int[] handValues)
        {
            Array.Sort(handValues);
            int handStrength = handValues.Sum();
            int totalCount = 0;
            int winningCount = 0;

            for (int i0 = 2; i0 <= 14; i0++)
                for (int i1 = 2; i1 <= 14; i1++)
                    for (int i2 = 2; i2 <= 14; i2++)
                        for (int i3 = 2; i3 <= 14; i3++)
                        {
                            int sum = i0 + i1 + i2 + i3;
                            bool winningHand = sum > handStrength;
                            if (winningHand) winningCount++;                            
                            totalCount++;
                        }
            return (decimal)winningCount / totalCount; 
        }             
    }
}