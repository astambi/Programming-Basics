using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Largest_Common_End
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine().Split(' ').ToArray();
            string[] words2 = Console.ReadLine().Split(' ').ToArray();
            int largestCommonEndLeft = LargestCommonEnd(words1, words2);

            words1 = words1.Reverse().ToArray();
            words2 = words2.Reverse().ToArray();
            int largestCommonEndRight = LargestCommonEnd(words1, words2);

            Console.WriteLine(Math.Max(largestCommonEndLeft,largestCommonEndRight));
        }

        static int LargestCommonEnd(string[] words1, string[] words2)
        {
            int rightCount = 0;
            while (rightCount < words1.Length && rightCount < words2.Length)
            {
                if (words1[words1.Length - rightCount - 1] == words2[words2.Length - rightCount - 1])
                    rightCount++;
                else break;
            }
            return rightCount;
        }
    }
}
