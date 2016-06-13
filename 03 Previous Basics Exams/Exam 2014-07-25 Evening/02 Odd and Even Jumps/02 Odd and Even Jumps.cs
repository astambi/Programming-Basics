using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odd_and_Even_Jumps
{
    class Odd_and_Even_Jumps
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string modifiedInput = "";            
            int[] count = { 1, 1 };     // [odd, even]
            int[] jump = { 0, 0 };      // [odd, even]
            long[] sum = { 0, 0 };      // [odd, even]
            string[] hex = { "", "" };  // [odd, even]
            char[] remaindersHex = { 'A', 'B', 'C', 'D', 'E', 'F' }; // {10,11,12,13,14,15}

            for (int i = 0; i < 2; i++)
                jump[i] = int.Parse(Console.ReadLine());

            // remove empty spaces from input
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                    modifiedInput += input[i];
            }
            // odd & even calculations
            for (int i = 0; i < modifiedInput.Length; i++)
            {
                int index = i % 2;
                if (i != 0 && i != 1)
                    count[index]++;
                else
                    count[index] = 1;
                if (count[index] % jump[index] != 0)
                    sum[index] += (int)modifiedInput[i];
                else
                    sum[index] *= (int)modifiedInput[i];
            }
            // convert dec into hex		
            for (int i = 0; i < 2; i++)
            {
                long decNum = sum[i];
                string hexNum = "";
                while (decNum > 0) // inverted hex number
                {
                    long remainder = decNum % 16;
                    if (remainder < 10)
                        hexNum += remainder;
                    else
                        hexNum += remaindersHex[remainder - 10];    // {10,...15}
                    decNum /= 16;
                }
                if (hexNum == "")
                    hexNum += 0;
                // reverse hex number
                for (int j = hexNum.Length - 1; j >= 0; j--)
                    hex[i] += hexNum[j];
            }
            Console.WriteLine("Odd: {0}", hex[0]);
            Console.WriteLine("Even: {0}", hex[1]);
        }
    }
}
