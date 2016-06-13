using System;

class Fallen_In_Love
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",
                                new string('~', i),
                                new string('.', 2 * n - 2 * i),
                                new string('.', 2 * i));
        }
        for (int i = n; i >= 0; i--)
        {
            Console.WriteLine("{0}#{1}#{2}#{1}#{0}",
                                new string('.', 2 * (n - i) + 1),
                                new string('~', i),
                                new string('.', 2 * i));
        }
        for (int i = 0; i < n; i++)
            Console.WriteLine("{0}##{0}", new string('.', 2 * n + 2));
    }
}