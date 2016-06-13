using System;

class Ace_of_Diamonds
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('*', n)); 
        for (int i = 0; i < (n - 2) / 2 + 1; i++) 
        {
            Console.WriteLine("*{0}{1}@{1}{0}*", 
                                new string('-', (n - 3) / 2 - i),
                                new string('@', i));
        }
        for (int i = (n - 2) / 2 - 1; i >= 0; i--) 
        {
            Console.WriteLine("*{0}{1}@{1}{0}*",
                                new string('-', (n - 3) / 2 - i),
                                new string('@', i));
        }
        Console.WriteLine(new string('*', n));
    }
}