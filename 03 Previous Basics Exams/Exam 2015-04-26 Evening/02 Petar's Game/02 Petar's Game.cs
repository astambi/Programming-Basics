using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Petar_s_Game
{
    class Petar_s_Game
    {
        static void Main(string[] args)
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());    // ulong
            ulong lastNumber = ulong.Parse(Console.ReadLine());
            string replacementString = Console.ReadLine();
            // NB bigInteger!!! // System.Numerics !!!
            BigInteger sum = 0;
            string result = "";
            char digitToBeReplaced = ' ';

            for (ulong i = firstNumber; i < lastNumber; i++)
            {
                if (i % 5 == 0)
                    sum = sum + i;
                else
                    sum = sum + i % 5;
            }
            string sumString = sum.ToString();

            if (sum % 2 == 0)                                       // if sum is even, finds first digit[0]
                digitToBeReplaced = sumString[0];
            else                                                    // if sum is odd, finds last digit[len-1]
                digitToBeReplaced = sumString[sumString.Length - 1];

            for (int i = 0; i < sumString.Length; i++)              // replaces digit with string
            {
                if (sumString[i] == digitToBeReplaced)
                    result += replacementString;
                else
                    result += sumString[i];
            }
            Console.WriteLine("{0}", result);
        }
    }
}
