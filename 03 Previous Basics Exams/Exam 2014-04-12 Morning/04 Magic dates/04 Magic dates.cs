using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Magic_dates
{
    class Magic_dates
    {
        static void Main(string[] args)
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int magicWeight = int.Parse(Console.ReadLine());

            DateTime startDate = new DateTime(startYear, 1, 1);
            DateTime endDate = new DateTime(endYear, 12, 31);
            bool foundMagicDate = false;

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                int[] dateDigits = GetDigits(date);
                int dateWeight = GetWeight(dateDigits);

                bool hasMagicWeight = dateWeight == magicWeight;
                if (hasMagicWeight)
                {
                    foundMagicDate = true;
                    Console.WriteLine("{0:d2}-{1:d2}-{2:d4}", date.Day, date.Month, date.Year);
                }
            }
            if(!foundMagicDate)
                Console.WriteLine("No");
        }

        static int[] GetDigits(DateTime date)
        {
            int[] dateDigits = new int[] {
                                date.Day / 10,
                                date.Day % 10,
                                date.Month / 10, 
                                date.Month % 10, 
                                date.Year / 1000 % 10, 
                                date.Year / 100  % 10, 
                                date.Year / 10 % 10, 
                                date.Year % 10};            
            return dateDigits;
        }

        static int GetWeight(int[] digits)
        {
            int sum = 0;
            for (int currentDigit = 0; currentDigit < digits.Length; currentDigit++)
            {
                for (int nextDigit = currentDigit + 1; nextDigit < digits.Length; nextDigit++)
                    sum += digits[currentDigit] * digits[nextDigit];
            }
            return sum;
        }
    }
}
