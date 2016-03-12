using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Type_3
{
    class Animal_Type_3
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            AnimalType(animal);            
        }

        static void AnimalType(string animal)
        {
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal"); break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile"); break;
                default:
                    Console.WriteLine("Unknown"); break;
            }
        }
    }
}
