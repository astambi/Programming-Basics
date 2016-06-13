using System;

class Local_Elections
{
    static void Main()
    {
        int lists = int.Parse(Console.ReadLine());
        int vote = int.Parse(Console.ReadLine());
        char votingSymbol = Console.ReadLine().ToUpper()[0]; // X x V v
        for (int list = 1; list <= lists; list++)
        {
            Console.WriteLine("{0}", new string('.', 13));
            if (list != vote)   // unchecked box => empty pattern
            {
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                Console.WriteLine("{0}|{1}|{0}", new string('.', 3), new string('.', 5));
                Console.WriteLine("{0:00}.|{1}|{2}", list, new string('.', 5), new string('.', 3));
                Console.WriteLine("{0}|{1}|{0}", new string('.', 3), new string('.', 5));
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
            }
            else if (votingSymbol == 'X') // voting pattern X
            {
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                Console.WriteLine("{0}|.\\./.|{0}", new string('.', 3), new string('.', 5));
                Console.WriteLine("{0:00}.|{1}X{1}|{2}", list, new string('.', 2), new string('.', 3));
                Console.WriteLine("{0}|./.\\.|{0}", new string('.', 3), new string('.', 5));
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
            }
            else if (votingSymbol == 'V') // voting pattern V
            {
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
                Console.WriteLine("{0}|\\{0}/|{0}", new string('.', 3), new string('.', 5));
                Console.WriteLine("{0:00}.|.\\./.|{1}", list, new string('.', 3));
                Console.WriteLine("{0}|{1}V{1}|{0}", new string('.', 3), new string('.', 2));
                Console.WriteLine("{0}+{1}+{0}", new string('.', 3), new string('-', 5));
            }
        }
        Console.WriteLine("{0}", new string('.', 13));
    }
}