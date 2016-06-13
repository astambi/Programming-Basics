using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Magic_Car_Numbers
{
    class _04_Magic_Car_Numbers
    {
        static void Main(string[] args)
        {
            int magicWeight = int.Parse(Console.ReadLine());
            char[] letters = new char[] { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
            int[] weights = new int[] { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
            int countMagicNumbers = 0;
            //List<string> magicNumbers = new List<string>();

            for (int i1 = 0; i1 < 10; i1++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    for (int i3 = 0; i3 < 10; i3++)
                    {
                        for (int i4 = 0; i4 < 10; i4++)
                        {
                            string digits = string.Join("", i1, i2, i3, i4);
                            bool isSpecialSequence = IsSpecialSequence(digits);
                            if (isSpecialSequence)
                            {
                                for (int ch1 = 0; ch1 < 10; ch1++)
                                {
                                    for (int ch2 = 0; ch2 < 10; ch2++)
                                    {
                                        string number = "CA" + digits + (char)letters[ch1] + (char)letters[ch2];
                                        int weight = i1 + i2 + i3 + i4
                                                    + weights[ch1] + weights[ch2]
                                                    + weights[0] + weights[2];
                                        bool hasMagicWeight = weight == magicWeight;
                                        if (hasMagicWeight)
                                        {
                                            countMagicNumbers++;
                                            //magicNumbers.Add(number);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(countMagicNumbers);
            //Console.WriteLine(string.Join("\n", magicNumbers));

        }

        static bool IsSpecialSequence(string number)
        {
            bool aaaa = number[0] == number[1] &&
                        number[1] == number[2] &&
                        number[2] == number[3];

            bool abbb = number[0] != number[1] &&
                        number[1] == number[2] &&
                        number[2] == number[3];

            bool aaab = number[0] == number[1] &&
                        number[1] == number[2] &&
                        number[2] != number[3];

            bool aabb = number[0] == number[1] &&
                        number[1] != number[2] &&
                        number[2] == number[3];

            bool abab = number[0] != number[1] &&
                        number[0] == number[2] &&
                        number[1] == number[3];

            bool abba = number[0] != number[1] &&
                        number[1] == number[2] &&
                        number[0] == number[3];

            return aaaa || abbb || aaab || aabb || abab || abba;
        }
    }
}
