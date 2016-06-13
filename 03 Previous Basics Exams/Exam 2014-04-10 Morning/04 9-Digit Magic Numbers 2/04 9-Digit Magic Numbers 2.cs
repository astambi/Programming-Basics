using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_9_Digit_Magic_Numbers
{
    class Nine_Digit_Magic_Numbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            bool foundMagicNumber = false;

            for (int a = 1; a <= 7; a++)
            {
                for (int b = 1; b <= 7; b++)
                {
                    for (int c = 1; c <= 7; c++)
                    {
                        for (int d = 1; d <= 7; d++)
                        {
                            for (int e = 1; e <= 7; e++)
                            {
                                for (int f = 1; f <= 7; f++)
                                {
                                    for (int g = 1; g <= 7; g++)
                                    {
                                        for (int h = 1; h <= 7; h++)
                                        {
                                            for(int i = 1; i <= 7; i++)
                                            {
                                                int sumOfDigits = a + b + c + d + e + f + g + h + i;
                                                if (sumOfDigits == sum)
                                                {
                                                    int numberABC = a * 100 + b * 10 + c;
                                                    int numberDEF = d * 100 + e * 10 + f;
                                                    if (numberDEF - numberABC == diff)  
                                                    {
                                                        int numberGHI = g * 100 + h * 10 + i;
                                                        if (numberGHI - numberDEF == diff)
                                                        {
                                                            Console.WriteLine(string.Join("", numberABC, numberDEF, numberGHI));
                                                            foundMagicNumber = true;
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
                }
            }
            if (!foundMagicNumber)
                Console.WriteLine("No");
        }       
    }
}
