using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Type_5
{
    class Animal_Type_5
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            AnimalType(animal);
        }
        static void AnimalType(string animal)
        {
            string type;
            switch (animal)
            {
                case "dog":
                    type = "mammal"; break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    type = "reptile"; break;
                default:
                    type = "Unknown"; break;
            }
            Console.WriteLine(type); 
        }
    }
}
