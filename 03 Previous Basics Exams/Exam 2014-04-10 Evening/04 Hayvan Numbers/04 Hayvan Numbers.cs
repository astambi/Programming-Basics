using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hayvan_Numbers
{
    class Hayvan_Numbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            bool foundHayvanNumber = false;

            for (int a = 5; a <= 9; a++)
            {
                for (int b = 5; b <= 9; b++)
                {
                    for (int c = 5; c <= 9; c++)
                    {
                        for (int d = 5; d <= 9; d++)
                        {
                            for (int e = 5; e <= 9; e++)
                            {
                                for (int f = 5; f <= 9; f++)
                                {
                                    for (int g = 5; g <= 9; g++)
                                    {
                                        for (int h = 5; h <= 9; h++)
                                        {
                                            for (int i = 5; i <= 9; i++)
                                            {
                                                int numberABC = a * 100 + b * 10 + c;
                                                int numberDEF = d * 100 + e * 10 + f;
                                                int numberGHI = g * 100 + h * 10 + i;
                                                int sumDigits = a + b + c + d + e + f + g + h + i;
                                                bool isHayvanNumber =   (sumDigits == sum) &&
                                                                        (numberGHI - numberDEF == diff) &&
                                                                        (numberDEF - numberABC == diff);
                                                if (isHayvanNumber)
                                                {
                                                    foundHayvanNumber = true;
                                                    Console.WriteLine(string.Join("", numberABC, numberDEF, numberGHI));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!foundHayvanNumber)
                Console.WriteLine("No");
        }
    }
}
