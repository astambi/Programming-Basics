using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Detective_Boev_2
{
    class Detective_Boev_2
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string encodedMessage = Console.ReadLine();
            string decodedMesssage = "";
            char[] decodedChars = new char[encodedMessage.Length];
            int sumChars = 0;
            int mask = 0;

            // constructing the decoding mask
            for (int i = 1; i <= secretWord.Length; i++)
                sumChars += (int)secretWord[i - 1];             // sums the ASCI values of all secretWord letters

            secretWord = sumChars.ToString();                   // converts the sum into string

            while (secretWord.Length > 1)
            {
                sumChars = 0;
                for (int i = 0; i < secretWord.Length; i++)
                    sumChars += (int)secretWord[i] - 48;        // adds all digits (ASCII value of digit 0 = 48)

                if (sumChars > 9)                               // repeats untill result is a single digit
                    secretWord = sumChars.ToString();
                else  
                {
                    mask = sumChars;                            // mask is sum of digits
                    break;
                }
            }
            // decoding message to ASCI values & chars
            for (int i = 0; i <= encodedMessage.Length - 1; i++)
            {
                int decodedCharValue = (int)encodedMessage[i];  // ASCI value char

                if (decodedCharValue % mask == 0)
                    decodedCharValue += mask;
                else
                    decodedCharValue -= mask;
                decodedChars[i] = (char)decodedCharValue;       // char from ASCII value
            }
            // decoding message: ASCI chars in reverse order
            for (int i = encodedMessage.Length - 1; i >= 0; i--)
                decodedMesssage += decodedChars[i];
            Console.WriteLine(decodedMesssage);
        }
    }
}
