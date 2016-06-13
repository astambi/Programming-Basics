using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Winning_Numbers
{
    class _04_Winning_Numbers
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int sumLetters = GetSumOfLetters(text);
            PrintWinningNumber(sumLetters);
        }

        static int GetSumOfLetters(string text)
        {
            int sumLetters = 0;
            foreach (char letter in text)
                sumLetters += char.ToLower(letter) - 'a' + 1; // letter position in alphabeth				
            return sumLetters;
        }
        static void PrintWinningNumber(int sumLetters)
        {
            bool foundWinningNumber = false;
            for (int i1 = 0; i1 < 10; i1++)
                for (int i2 = 0; i2 < 10; i2++)
                    for (int i3 = 0; i3 < 10; i3++)
                        for (int i4 = 0; i4 < 10; i4++)
                            for (int i5 = 0; i5 < 10; i5++)
                                for (int i6 = 0; i6 < 10; i6++)
                                {
                                    bool leftProductEqualsSumLetters = i1 * i2 * i3 == sumLetters;
                                    bool rightProductEqualsSumLetters = i4 * i5 * i6 == sumLetters;
                                    if (leftProductEqualsSumLetters && rightProductEqualsSumLetters)
                                    {
                                        Console.WriteLine("{0}{1}{2}-{3}{4}{5}", i1, i2, i3, i4, i5, i6);
                                        foundWinningNumber = true;
                                    }
                                }
            if (!foundWinningNumber) Console.WriteLine("No");
        }
    }
}