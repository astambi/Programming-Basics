using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Type
{
    class Animal_Type
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":         Console.WriteLine("mammal"); break;
                case "crocodile":   Console.WriteLine("reptile"); break;
                case "tortoise":    Console.WriteLine("reptile"); break;
                case "snake":       Console.WriteLine("reptile"); break;
                default:            Console.WriteLine("Unknown"); break;
            }
        }
    }
}
