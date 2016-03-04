using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Detective_Boev
{
    class Detective_Boev
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string encodedMessage = Console.ReadLine();
            string decodedMesssage = "";
            char[] decodedChars = new char[encodedMessage.Length];
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int sumChars = 0;
            int mask = 0;

            // mask
            for (int i = 1; i <= secretWord.Length; i++)
                sumChars += (int)secretWord[i - 1];         // sums the ASCI values of all secretWord letters
            secretWord = sumChars.ToString();               // converts sum into string
            int len = secretWord.Length;
            while (len > 1)
            {
                sumChars = 0;
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j <= 9; j++)
                        if (secretWord[i] == digits[j])     // sum digits
                            sumChars += j;
                }
                if (sumChars <= 9)
                {
                    len = 1;
                    mask = sumChars;                        // mask is sum of digits
                }
                else
                {
                    secretWord = sumChars.ToString();
                    len = secretWord.Length;
                }
            }
            // decoding message to ASCI values
            for (int i = 1; i <= encodedMessage.Length; i++)
            {
                int decodedCharValue = (int)encodedMessage[i - 1];  // ASCI value char
                if (decodedCharValue % mask == 0)
                    decodedCharValue += mask; 
                else
                    decodedCharValue -= mask; 
                decodedChars[i - 1] = (char)decodedCharValue;       // char from ASCII value
            }
            // decoding ASCI values to ASCI chars in reverse order
            for (int i = encodedMessage.Length - 1; i >= 0; i--)
                decodedMesssage += decodedChars[i];
            Console.WriteLine(decodedMesssage);
        }
    }
}
