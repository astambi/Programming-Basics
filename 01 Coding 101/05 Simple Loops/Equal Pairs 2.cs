using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs_2
{
    class Equal_Pairs_2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 2*n  numbers
            double currentValuePair = double.Parse(Console.ReadLine()) + double.Parse(Console.ReadLine()); //1st sum
            double previousValuePair = currentValuePair;
            double currentDiffPairs = 0;
            double maxDiffPairs = 0;
            
            for (int i = 0; i < n-1; i++) //n-1 sums
            {
                currentValuePair = double.Parse(Console.ReadLine()) + double.Parse(Console.ReadLine()); 
                currentDiffPairs = Math.Abs(currentValuePair - previousValuePair);
                if (currentDiffPairs > maxDiffPairs)
                    maxDiffPairs = currentDiffPairs;
                previousValuePair = currentValuePair;
            }
            bool noDiffs = maxDiffPairs == 0;
            if (noDiffs)
                Console.WriteLine("Yes, value={0}", currentValuePair);
            else
                Console.WriteLine("No, maxdiff={0}", maxDiffPairs);
        }
    }
}
