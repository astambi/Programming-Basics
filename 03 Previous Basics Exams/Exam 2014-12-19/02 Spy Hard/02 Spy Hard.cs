using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Spy_Hard
{
    class Spy_Hard
    {
        static void Main(string[] args)
        {
            // construct a partially decrypted message containing:
            // 1. numerical system, 2. encypted message length, 
            // 3. encrypted message converted into a number in new numerical system
            int key = int.Parse(Console.ReadLine());                // numerical system with base = key
            string encryptedMessage = Console.ReadLine().ToLower();
            string partiallyDecryptedMessage = "";
            double sumValues = 0;       

            // adds numerical system & message length to partially decrypted message
            partiallyDecryptedMessage += key;
            partiallyDecryptedMessage += encryptedMessage.Length;
            // ASCII values encrypted message
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                int value = (int)encryptedMessage[i];               // ASCII values 
                bool smallLetters = value >= 97 && value <= 122;    // ASCII values small letters [a,z]
                if (smallLetters)                                   // takes the position of a letter in the alphabeth, letter A,a = 1
                    value -= 96;                                    // any other symbol takes the symbol's ASCII value
                sumValues += value;
            }
            // determines max power in new numerical system
            int tempNumber = (int)sumValues;
            int power = 0; 
            while (tempNumber / key > 0)
            {
                tempNumber /= key;
                power++;
            }
            // converts sumValues into numerical system with base = key
            string numberNumericalSystem = "";
            for (int i = power; i >= 0;  i--)
            {
                double keyPoweri = Math.Pow(key, i); 
                double digit = Math.Truncate(sumValues / keyPoweri);
                numberNumericalSystem += digit;
                sumValues -= digit * keyPoweri;
            }
            // adds number in new numerical system to partially decrypted message
            partiallyDecryptedMessage += numberNumericalSystem;
            Console.WriteLine(partiallyDecryptedMessage);
        }
    }
}
