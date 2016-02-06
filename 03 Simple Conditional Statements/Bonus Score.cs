using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double score = 0.0;

            if (number <= 100)
                score += 5;
            else if (number > 1000)
                score += number * 0.1;
            else 
                score += number * 0.2;

            if (number % 2 == 0)
                score += 1;
            else if (number % 10 == 5)
                score += 2;

            Console.WriteLine("Bonus score: {0}", score);
            Console.WriteLine("Total score: {0}", number + score);
        }
    }
}