using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Tables
{
    class Tables
    {
        static void Main(string[] args)
        {
            long tableLegs = 0;
            for (int i = 1; i <= 4; i++)
                tableLegs += i * long.Parse(Console.ReadLine()); // packets with {1,2,3,4} legs
            long tableTops = long.Parse(Console.ReadLine());
            long demandTables = long.Parse(Console.ReadLine());

            long tablesProduced = Math.Min(tableTops, tableLegs / 4);
            long diffTables = tablesProduced - demandTables;
            if (tablesProduced > demandTables)
            {
                Console.WriteLine("more: {0}", diffTables);
                Console.WriteLine("tops left: {0}, legs left: {1}",
                                  tableTops - demandTables,
                                  tableLegs - demandTables * 4);
            }
            else if (tablesProduced < demandTables)
            {
                Console.WriteLine("less: {0}", diffTables);
                Console.WriteLine("tops needed: {0}, legs needed: {1}",
                                  Math.Max(0, demandTables - tableTops),
                                  Math.Max(0, demandTables * 4 - tableLegs));
            }
            else
                Console.WriteLine("Just enough tables made: {0}", tablesProduced);
        }
    }
}
