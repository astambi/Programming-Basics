using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Enter_Even_Number
    {
        static void Main(string[] args)
        {
            int n = 0;            
            
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter even number: ");
                    n = int.Parse(Console.ReadLine()); // try... catch

                    if (n % 2 == 0)
                        break;

                    Console.WriteLine("The number is not even.");
                }
                catch
                {
                    Console.WriteLine("Invalid number.");
                }                                  
            }                       
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
