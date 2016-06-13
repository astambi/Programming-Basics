using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Work_Hours
{
    class _01_Work_Hours
    {
        static void Main(string[] args)
        {
            int hoursRequired = int.Parse(Console.ReadLine());
            double daysAvailable = int.Parse(Console.ReadLine());
            int productivity = int.Parse(Console.ReadLine());
            int workinghoursPerDay = 12;

            double hoursAvailable = daysAvailable * 0.9 * workinghoursPerDay * productivity / 100;
            double diff = Math.Truncate(hoursAvailable) - hoursRequired;

            if (diff >= 0)
                Console.WriteLine("Yes\n{0}", diff);
            else
                Console.WriteLine("No\n{0}", diff);
        }
    }
}
