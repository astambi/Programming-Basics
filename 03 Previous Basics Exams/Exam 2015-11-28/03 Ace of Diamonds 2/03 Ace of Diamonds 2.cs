using System;

class Ace_of_Diamonds
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('*', n));
        for (int i = 1; i <= n - 2; i += 2)
        {
            Console.WriteLine("*{0}{1}{0}*",
                                new string('-', (n - 2 - i) / 2),
                                new string('@', i));
        }
        for (int i = (n - 2) - 2; i >= 1; i -= 2)
        {
            Console.WriteLine("*{0}{1}{0}*",
                                    new string('-', (n - 2 - i) / 2),
                                    new string('@', i));
        }
        Console.WriteLine(new string('*', n));
    }
}