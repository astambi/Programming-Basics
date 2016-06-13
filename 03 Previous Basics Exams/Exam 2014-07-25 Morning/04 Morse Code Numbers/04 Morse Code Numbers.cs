using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Morse_Code_Numbers
{
    class _04_Morse_Code_Numbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] morseCodes = new string[] { "-----",".----","..---","...--","....-","....."};

            int sumDigits = SumDigits(number);
            bool foundMorseNumbers = false;

            for (int n1 = 0; n1 < 6; n1++)
                for (int n2 = 0; n2 < 6; n2++)
                    for (int n3 = 0; n3 < 6; n3++)
                        for (int n4 = 0; n4 < 6; n4++)
                            for (int n5 = 0; n5 < 6; n5++)
                                for (int n6 = 0; n6 < 6; n6++)
                                {
                                    int morseProduct = n1 * n2 * n3 * n4 * n5 * n6;
                                    bool equality = morseProduct == sumDigits;
                                    if (equality)
                                    {
                                        Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|", 
                                            morseCodes[n1], morseCodes[n2], morseCodes[n3], 
                                            morseCodes[n4], morseCodes[n5], morseCodes[n6]);
                                        foundMorseNumbers = true;
                                    }
                                }
            if (!foundMorseNumbers) Console.WriteLine("No");
        }

        static int SumDigits(int number)
        {
            int sumDigits = 0;
            while (number > 0)
            {
                sumDigits += number % 10;
                number /= 10;
            }
            return sumDigits;
        }
    }
}