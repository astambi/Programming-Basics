using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Cheat_Sheet
{
    class Cheat_Sheet
    {
        static void Main(string[] args)
        {
            long rows = long.Parse(Console.ReadLine());
            long columns = long.Parse(Console.ReadLine());
            long verticalStartNumber = long.Parse(Console.ReadLine());
            long horizontalStartNumber = long.Parse(Console.ReadLine());

            for (long i = verticalStartNumber; i < verticalStartNumber + rows; i++)
            {
                string multiplicationTable = "";
                for (long j = horizontalStartNumber; j < horizontalStartNumber + columns; j++)
                    multiplicationTable += i * j + " ";

                // remove the last whitespace from string
                multiplicationTable = multiplicationTable.Substring(0, multiplicationTable.Length - 1);

                Console.WriteLine(multiplicationTable);
            }
        }
    }
}
