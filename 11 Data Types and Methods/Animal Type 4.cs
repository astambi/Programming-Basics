using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Type_4
{
    class Animal_Type_4
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            string animalType = AnimalType(animal);
            Console.WriteLine(animalType);
        }

        static string AnimalType(string animal)
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
            return type;
        }
    }
}
