using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Magic_Strings
{
    class Magic_Strings
    {
        static void Main(string[] args)
        {
            int diff = int.Parse(Console.ReadLine());
            char[] letters = new char[] { 'k', 'n', 'p', 's' };
            List<string> magicStrings = new List<string>();
            bool foundMagicString = false;

            for (int i1 = 0; i1 < 4; i1++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    for (int i3 = 0; i3 < 4; i3++)
                    {
                        for (int i4 = 0; i4 < 4; i4++)
                        {
                            for (int i5 = 0; i5 < 4; i5++)
                            {
                                for (int i6 = 0; i6 < 4; i6++)
                                {
                                    for (int i7 = 0; i7 < 4; i7++)
                                    {
                                        for (int i8 = 0; i8 < 4; i8++)
                                        {
                                            int sumLeft = GetSumOfWeights(i1, i2, i3, i4);
                                            int sumRight = GetSumOfWeights(i5, i6, i7, i8);
                                            int currentDiff = Math.Abs(sumLeft - sumRight);
                                            if (currentDiff == diff)
                                            {
                                                string magicString = string.Empty + 
                                                                    letters[i1] + letters[i2] + letters[i3] + letters[i4] + 
                                                                    letters[i5] + letters[i6] + letters[i7] + letters[i8];
                                                Console.WriteLine(magicString);
                                                foundMagicString = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }            
            if(!foundMagicString) Console.WriteLine("No");
        }

        static int GetSumOfWeights(int num1, int num2, int num3, int num4)
        {
            int[] weights = new int[] { 1, 4, 5, 3 };
            int sum = weights[num1] + weights[num2] + weights[num3] + weights[num4];
            return sum;
        }
    }
}
