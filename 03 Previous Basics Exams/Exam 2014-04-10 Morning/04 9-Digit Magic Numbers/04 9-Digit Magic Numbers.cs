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

            for (int numberLeft = 111; numberLeft <= 777; numberLeft++)
            {
                if (IsValidNumber(numberLeft))
                {
                    int numberMiddle = diff + numberLeft;
                    int numberRight = diff + numberMiddle;
                    if (IsValidNumber(numberMiddle) && IsValidNumber(numberRight))
                    {
                        if (sum == GetSumOfDigits(numberLeft, numberMiddle, numberRight))
                        {
                            Console.WriteLine(string.Join("", numberLeft, numberMiddle, numberRight));
                            foundMagicNumber = true;
                        }
                    }
                }            
            }
            if (!foundMagicNumber)
                Console.WriteLine("No");
        }

        static bool IsValidNumber(int number)
        {
            string invalidDigits = "089";
            if (number < 111 || number > 777)
            {
                return false;
            }
            foreach (char digit in number.ToString())
            {
                if (invalidDigits.Contains(digit))
                    return false;
            }
            return true;
        }

        static int GetSumOfDigits(int numberLeft, int numberMiddle, int numberRight)
        {
            int sum = 0;
            while (numberLeft > 0)
            {
                sum += numberLeft % 10;
                numberLeft /= 10;
            }
            while (numberMiddle > 0)
            {
                sum += numberMiddle % 10;
                numberMiddle /= 10;
            }
            while (numberRight > 0)
            {
                sum += numberRight % 10;
                numberRight /= 10;
            }
            return sum;
        }
    }
}
