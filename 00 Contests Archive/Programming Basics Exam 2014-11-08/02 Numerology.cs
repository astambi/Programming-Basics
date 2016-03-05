using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Numerology
{
    class Numerology
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  // format "day.month.year username"
            long celestialNumber = 0; 

            // splits input into array[2]
            string[] splitInput = input.Split(' '); 
            string birthdate = splitInput[0];
            string username = splitInput[1];

            // splits birthdate into array[3] { day, month, year}
            string[] splitBirthdate = birthdate.Split('.');
            int day = int.Parse(splitBirthdate[0]);
            int month = int.Parse(splitBirthdate[1]);
            int year = int.Parse(splitBirthdate[2]);

            // mupliply day, month, year to get celestial number
            celestialNumber = day * month * year;
            if (month % 2 != 0)
                celestialNumber *= celestialNumber;

            // add each username digit or letter position to celestial number
            for (int i = 0; i < username.Length; i++)
            {
                int value = (int)username[i];

                bool digit = value >= 48 && value <= 57;        // ASCII values
                bool smallLetter = value >= 97 && value <= 122;
                bool capitalLetter = value >= 65 && value <= 90;

                if (digit)
                    celestialNumber += value - 48;              // digits [0,9]
                else if (smallLetter)
                    celestialNumber += value - 97 + 1;          // letter position in alphabet a=1
                else if (capitalLetter)
                    celestialNumber += 2 * (value - 65 + 1);    // letter position in alphabet 2*A=1
            }

            // sums celestial number digits
            while (celestialNumber > 13)                        // until sum is a sacral number [0;13]
            {
                long newCelestialNumber = 0;
                long len = celestialNumber.ToString().Length;   // original celestial number length
                for (long i = 0; i < len ; i++)                 // NB. len calc outside for cycle !!!
                {
                    newCelestialNumber += celestialNumber % 10;
                    celestialNumber /= 10;
                }
                celestialNumber = newCelestialNumber;
            }
            
            Console.WriteLine(celestialNumber);
        }
    }
}
