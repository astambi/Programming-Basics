using System;

namespace Illuminati_Lock
{
    class Illuminati_Lock
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", 
                                new string('.', n), 
                                new string('#', n));
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", 
                                new string('.', n - 2 - 2 * i), 
                                new string('.', 2 * i), 
                                new string('.', n - 2));
            }
            for (int i = (n - 1) / 2 - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", 
                                new string('.', n - 2 - 2 * i), 
                                new string('.', 2 * i), 
                                new string('.', n - 2));
            }
            Console.WriteLine("{0}{1}{0}",
                                new string('.', n),
                                new string('#', n));
        }
    }
}