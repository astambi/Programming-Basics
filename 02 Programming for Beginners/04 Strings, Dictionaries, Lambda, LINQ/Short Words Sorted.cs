using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    class Short_Words_Sorted
    {
        static void Main(string[] args)
        {
            char[] separators = ".,:;()[]\"'!? ".ToCharArray();
            string[] words = Console.ReadLine()
                            .ToLower()
                            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                            .Where(word => word.Length < 5)
                            .OrderBy(w => w)
                            .Distinct()
                            .ToArray();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}