using System;

class Plaid_Towel
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());  // width =  4 * n + 1
        char backgroundSymbol = Console.ReadLine()[0];
        char rhombusSymbol = Console.ReadLine()[0];

        for (int pattern = 0; pattern < 2; pattern++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}",
                                new string(backgroundSymbol, n), rhombusSymbol,
                                new string(backgroundSymbol, 2 * n - 1));
            for (int i = n - 1; i > 0; i--)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                                new string(backgroundSymbol, i), rhombusSymbol,
                                new string(backgroundSymbol, 2 * (n - i) - 1),
                                new string(backgroundSymbol, 2 * i - 1));
            }
            Console.WriteLine("{0}{1}{0}{1}{0}", rhombusSymbol,
                                new string(backgroundSymbol, 2 * n - 1));
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                                new string(backgroundSymbol, i), rhombusSymbol,
                                new string(backgroundSymbol, 2 * (n - i) - 1),
                                new string(backgroundSymbol, 2 * i - 1));
            }
        }
        Console.WriteLine("{0}{1}{2}{1}{0}",
                                new string(backgroundSymbol, n), rhombusSymbol,
                                new string(backgroundSymbol, 2 * n - 1));
    }
}