using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Equal_Pairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 2*n  numbers
            double[] valuePairs = new double[n];
            double[] diffPairs = new double[n - 1];

            for (int i = 0; i < n; i++)
                valuePairs[i] = double.Parse(Console.ReadLine()) + double.Parse(Console.ReadLine()); //n sums
            for (int i = 0; i < n-1; i++)
                diffPairs[i] = Math.Abs(valuePairs[i + 1] - valuePairs[i]);

            double maxDiffPairs = 0;
            for (int i = 0; i < n-1; i++) //comparison n-1 diffs
            {
                if (diffPairs[i] > maxDiffPairs)
                    maxDiffPairs = diffPairs[i];                      
            }

            bool noDiffs = maxDiffPairs == 0;
            if (noDiffs)
                Console.WriteLine("Yes, value={0}",valuePairs[0]);
            else
                Console.WriteLine("No, maxdiff={0}", maxDiffPairs);
        }
    }
}
